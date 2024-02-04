using ShoeStore.BL.Interfaces;
using ShoeStore.DL.Interfaces;
using ShoeStore.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.BL.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandService brandRepository)
        {
            _brandRepository = (IBrandRepository?)brandRepository;
        }

        public List<Brand> GetAllBrands()
        {
            return _brandRepository.GetAllBrands();
        }

        public Brand GetBrand(int Id)
        {
            if (Id > 50000) return null;
            return _brandRepository.GetBrand(Id);
        }

        public void AddBrand(Brand brand)
        {
            _brandRepository.AddBrand(brand);
        }

        public void RemoveBrand(Brand brand)
        {
            _brandRepository.RemoveBrand(brand);
        }
    }
}
