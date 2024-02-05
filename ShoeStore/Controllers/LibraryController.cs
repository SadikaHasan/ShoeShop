using Microsoft.AspNetCore.Mvc;
using ShoeStore.BL.Interfaces;
using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;

namespace ShoeStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : Controller
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet("GetAllShoesByBrandAndDate")]
        public GetAllShoesByBrandResponse?
            GetAllShoesByBrandAndDate([FromBody]
             GetAllShoesByBrandRequest request)
        {
            return _libraryService
                .GetAllShoesByBrandAfterReleaseDate(request);
        }

        [HttpGet("SomeEndPoint")]
        public string GetSomeData([FromBody] SomeRequest request)
        {
            return "Ok";
        }
    }
}
