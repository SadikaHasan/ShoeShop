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
            if (Id <= 0) return new Shoe();
            return _shoeRepository.GetShoe(Id);
        }
    public void AddShoe(Shoe shoe)
        {
            _shoeRepository.AddShoe(shoe);
        }
        public void RemoveShoe(Shoe shoe)
        {
            _shoeRepository.RemoveShoe(shoe);
        }

    public List<Shoe> GetAllByBrandAfterReleaseDate
            (int brandId, DateTime afterDate)
        {
            var result = _shoeRepository.GetAllByBrand(brandId);

            return result
                .Where(b => b.ReleaseDate >= afterDate)
                .ToList();
        }

        public void RemoveShoe(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Shoe> GetAllByBrandsAfterReleaseDate(int brandId, DateTime afterDate)
        {
            throw new NotImplementedException();
        }
    }

}
