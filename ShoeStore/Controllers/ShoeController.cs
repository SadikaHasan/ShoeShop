using Microsoft.AspNetCore.Mvc;

namespace ShoeStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoeController : Controller
    {
        private readonly IShoeService _shoeService;

        public ShoeController(IShoeService shoeService)
        {
            _shoeService = shoeService;
        }

        [HttpGet("GetAllShoes")]
        public List<Shoe> GetAllShoes()
        {
            return _shoeService.GetAllShoes();
        }

        [HttpGet("GetShoe")]
        public Shoe GetShoe()
        {
            return _shoeService.GetShoe();
        }

        [HttpGet("AddShoe")]
        public void AddShoe([FromBody] Shoe shoe)
        {
            _shoeService.GetShoe();
        }

        [HttpGet("RemoveShoe")]
        public void RemoveShoe(int Id)
        {
            _shoeService.RemoveShoe(Id);
        }
    }
}
