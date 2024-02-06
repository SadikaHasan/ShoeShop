using ShoeStore.BL.Interfaces;
using ShoeStore.DL.Interfaces;
using ShoeStore.Models.models;

namespace ShoeStore.BL.Services
{
    public class ShoeService : IShoeService
    {
        private readonly IShoeRepository _shoeRepository;

        public ShoeService(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        public List<Shoe> GetAllShoes()
        {
            return _shoeRepository.GetAllShoes();
        }

        public Shoe GetShoe(int Id)
        {
            if (Id <= 0)
                return null; // Consider throwing an ArgumentException instead
            return _shoeRepository.GetShoe(Id);
        }

        public void AddShoe(Shoe shoe)
        {
            _shoeRepository.AddShoe(shoe);
        }

        public void RemoveShoe(int Id)
        {
            var shoe = _shoeRepository.GetShoe(Id);
            if (shoe != null)
                _shoeRepository.RemoveShoe(shoe);
            // You may want to throw an exception if the shoe doesn't exist
        }

        public List<Shoe> GetAllByBrandAfterReleaseDate(int brandId, DateTime afterDate)
        {
            var result = _shoeRepository.GetAllByBrand(brandId);
            return result.Where(b => b.ReleaseDate >= afterDate).ToList();
        }

        // Explicit interface implementations
        List<Shoe> IShoeService.GetAllShoes()
        {
            return GetAllShoes();
        }

        Shoe IShoeService.GetShoe(int Id)
        {
            return GetShoe(Id);
        }

        void IShoeService.AddShoe(Shoe shoe)
        {
            AddShoe(shoe);
        }

        void IShoeService.RemoveShoe(int Id)
        {
            RemoveShoe(Id);
        }

        List<Shoe> IShoeService.GetAllByBrandsAfterReleaseDate(int brandId, DateTime afterDate)
        {
            return GetAllByBrandAfterReleaseDate(brandId, afterDate);
        }
    }
}
