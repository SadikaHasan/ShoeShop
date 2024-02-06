using ShoeStore.BL.Interfaces;
using ShoeStore.DL.Interfaces;
using ShoeStore.DL.Repository;
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

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public BrandService(BrandRepository brandRepository)
        {
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

        List<Brand> IBrandService.GetAllBrands()
        {
            throw new NotImplementedException();
        }

        Brand IBrandService.GetBrand(int Id)
        {
            throw new NotImplementedException();
        }

        void IBrandService.AddBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        void IBrandService.RemoveBrand(int Id)
        {
            throw new NotImplementedException();
        }

        Brand IBrandService.GetBrand()
        {
            throw new NotImplementedException();
        }

        void IBrandService.AddBrand()
        {
            throw new NotImplementedException();
        }
    }
}
