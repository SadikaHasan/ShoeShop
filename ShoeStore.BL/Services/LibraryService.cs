using ShoeStore.BL.Interfaces;
using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IBrandService _brandService;
        private readonly IShoeService _shoeService;

        public LibraryService(
           IBrandService brandService,
           IShoeService shoeService)
        {
            _brandService = brandService;
            _shoeService = shoeService;
        }

        public LibraryService(Func<object> shoeService, Func<object> brandService)
        {
        }

        public int CheckShoeCount(int input)
        {
            if (input < 0) return 0;
            var shoeCount = _shoeService.GetAllShoes;
            return shoeCount.Count + input;
        }

        public GetAllShoesByBrandResponse?
        GetAllByBrandsAfterReleaseDate(
            GetAllShoesByBrandRequest request)
        {
            var response = new GetAllShoesByBrandResponse
            {
                Brand= _brandService
                .GetBrand(request.BrandId),
                Shoe= _shoeService
                .GetAllByBrandsAfterReleaseDate(
                    request.BrandId,
                    request.DateAfter)
            };
            return response;
        }

        int ILibraryService.CheckShoeCount(int input)
        {
            throw new NotImplementedException();
        }

        GetAllShoesByBrandResponse? ILibraryService.GetAllByBrandsAfterReleaseDate(GetAllShoesByBrandRequest request)
        {
            throw new NotImplementedException();
        }

        GetAllShoesByBrandResponse? ILibraryService.GetAllShoesByBrandAfterReleaseDate(GetAllShoesByBrandRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
