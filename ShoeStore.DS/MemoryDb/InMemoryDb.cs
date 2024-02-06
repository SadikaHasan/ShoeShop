using ShoeStore.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Brand> BrandsData
            = new List<Brand>()
        {
            new Brand()
            {
                Id=1,
                Name="brand 1",
                BirthDay = DateTime.Now,
            },
            new Brand()
            {
                Id=2,
                Name="brand 2",
                BirthDay = DateTime.Now,

            },
            new Brand()
            {
                Id=3,
                Name="brand 3",
                BirthDay = DateTime.Now,

            },
        };

        public static List<Shoe> Shoes = new List<Shoe>()
        {
            new Shoe()
            {
                Id= 1,
                Size=37,
                BrandId = 1,
                ReleaseDate= new DateTime(2006,02,10)
            },
            new Shoe()
            {
                Id= 2,
                Size=38,
                BrandId = 2,
                ReleaseDate= new DateTime(2007,02,10)
            },
            new Shoe()
            {
                Id= 3,
                Size=39,
                BrandId = 3,
                ReleaseDate= new DateTime(2008,02,10)
            },
        };
    }
}
