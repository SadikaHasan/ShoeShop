using Microsoft.AspNetCore.Mvc;
using ShoeStore.BL.Interfaces;
using ShoeStore.Models.models;

namespace ShoeStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetAllBrands")]
        public List<Brand> GetAllBrands()
        {
            return _brandService.GetAllBrands();
        }

        [HttpGet("GetBrand")]
        public Brand GetBrand()
        {
            return _brandService.GetBrand();
        }

        [HttpGet("AddBrand")]
        public void AddBrand([FromBody] Brand brand)
        {
            _brandService.AddBrand();
        }

        [HttpGet("RemoveBrand")]
        public void RemoveBrand(int Id)
        {
            _brandService.RemoveBrand(Id);
        }
    }
}
