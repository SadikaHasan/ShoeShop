using ShoeStore.DL.DL;
using ShoeStore.DL.Interfaces;
using ShoeStore.DL.MemoryDb;
using ShoeStore.Models.models;

namespace ShoeStore.DL.Repository
{
    public class BrandRepository: IBrandRepository
    {
        public void AddBrand(Brand brand)
        {
            InMemoryDb.BrandsData.Add(brand);
        }

        public List<Brand> GetAllBrands()
        {
            return InMemoryDb.BrandsData;
        }

        public Brand? GetBrand(int Id)
        {
            return
                InMemoryDb.BrandsData
                .First(b => b.Id == Id);
        }

        public void RemoveBrand(Brand brand)
        {
            if (brand == null) return;
            InMemoryDb.BrandsData.Remove(brand);
        }

    }
}
