using Microsoft.AspNetCore.Mvc;
using ShoeStore.BL.Interfaces;
using ShoeStore.Models.models;

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
        public Shoe GetShoe(int Id) // Add 'Id' parameter here
        {
            return _shoeService.GetShoe(Id);
        }

        [HttpPost("AddShoe")] // Change to HttpPost as it's modifying data
        public void AddShoe([FromBody] Shoe shoe)
        {
            _shoeService.AddShoe(shoe);
        }

        [HttpDelete("RemoveShoe")] // Change to HttpDelete as it's deleting data
        public void RemoveShoe(int Id)
        {
            _shoeService.RemoveShoe(Id);
        }
    }
}
