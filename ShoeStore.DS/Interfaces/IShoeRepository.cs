using ShoeStore.Models.models;

namespace ShoeStore.DL.Interfaces
{
    public interface IShoeRepository
    {
        public void AddShoe(Shoe shoe);


        public void RemoveShoe(Shoe shoe);


        public Shoe GetShoe(int Id);


        public List<Shoe> GetAllShoes();

        List<Shoe> GetAllByBrand(int brandId);
    }
}
