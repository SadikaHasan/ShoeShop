using Microsoft.AspNetCore.Mvc;
using ShoeStore.BL.Interfaces;
using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;

namespace ShoeStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet("GetAllShoesByBrandAndDate")]
        public GetAllShoesByBrandResponse?
            GetAllShoesByBrandAndDate([FromBody]
             GetAllShoesByBrandRequest request)
        {
            return _storeService
                .GetAllShoesByBrandAfterReleaseDate(request);
        }

        [HttpGet("SomeEndPoint")]
        public string GetSomeData([FromBody] SomeRequest request)
        {
            return "Ok";
        }
    }
}
