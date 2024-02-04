using ShoeStore.DL.DL;
using ShoeStore.DL.Interfaces;
using ShoeStore.DL.MemoryDb;
using ShoeStore.Models.models;

namespace ShoeStore.DL.Repository
{
    public class ShoeRepository: IShoeRepository
    {
        public void AddShoe(Shoe shoe)
        {
            InMemoryDb.Shoes.Add(shoe);
        }

        public List<Shoe> GetAllShoes()
        {
            return InMemoryDb.Shoes;
        }

        public Shoe? GetShoe(int Id)
        {
            return
                InMemoryDb.Shoes
                .First(b => b.Id == Id);
        }

        public void RemoveShoe(Shoe shoe)
        {
            if (shoe == null) return;
            InMemoryDb.Shoes.Remove(shoe);
        }

        public List<Shoe> GetAllByBrand(int brandId)
        {
            return InMemoryDb.Shoes
                .Where(b => b.BrandId == brandId)
                .ToList();
        }
    }
}
