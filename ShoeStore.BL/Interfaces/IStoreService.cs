using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;

namespace ShoeStore.BL.Interfaces
{
    public interface IStoreService
    {
        GetAllShoesByBrandResponse?
            GetAllByBrandsAfterReleaseDate(
            GetAllShoesByBrandRequest request);

        public int CheckShoeCount();

        public GetAllShoesByBrandResponse? GetAllShoesByBrandAfterReleaseDate(GetAllShoesByBrandRequest request);
    }
}
