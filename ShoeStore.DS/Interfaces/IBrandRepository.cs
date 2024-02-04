using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models.models;

namespace ShoeStore.DL.Interfaces
{
    public interface IBrandRepository
    {
        public void AddBrand(Brand brand);


        public void RemoveBrand(Brand brand);


        public Brand GetBrand(int Id);


        public List<Brand> GetAllBrands();

    }
}
