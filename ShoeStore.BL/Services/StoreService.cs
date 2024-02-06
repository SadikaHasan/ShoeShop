using ShoeStore.BL.Interfaces;
using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;

namespace ShoeStore.BL.Services
{
    public class StoreService : IStoreService
    {
        private readonly IBrandService _brandService;
        private readonly IShoeService _shoeService;

        public StoreService(IBrandService brandService, IShoeService shoeService)
        {
            _brandService = brandService;
            _shoeService = shoeService;
        }

        public int CheckShoeCount()
        {
            return _shoeService.GetAllShoes().Count;
        }

        public GetAllShoesByBrandResponse? GetAllByBrandsAfterReleaseDate(GetAllShoesByBrandRequest request)
        {
            var response = new GetAllShoesByBrandResponse
            {
                Brand = _brandService.GetBrand(request.BrandId),
                Shoe = _shoeService
                .GetAllByBrandsAfterReleaseDate(
                                                request.BrandId, 
                                                request.DateAfter)
            };
            return response;
        }

        public GetAllShoesByBrandResponse? GetAllShoesByBrandAfterReleaseDate(GetAllShoesByBrandRequest request)
        {
            return GetAllByBrandsAfterReleaseDate(request);
        }
    }
}
