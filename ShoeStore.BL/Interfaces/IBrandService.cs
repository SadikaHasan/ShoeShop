using ShoeStore.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.BL.Interfaces
{
    public interface IBrandService
    {
        List<Brand> GetAllBrands();

        Brand GetBrand(int Id);

        void AddBrand(Brand brand);

        void RemoveBrand(int Id);
        Brand GetBrand();
        void AddBrand();
    }
}
