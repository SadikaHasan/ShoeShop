using ShoeStore.Models.models;

namespace ShoeStore.DL.DL
{
    internal class StaticData
    {
        public static List<Shoe> Shoes = new List<Shoe>()
        {
            new Shoe()
            {
                Id= 1,
                Size=37,
            },
            new Shoe()
            {
                Id= 2,
                Size=38,
            },
            new Shoe()
            {
                Id= 3,
                Size=39,
            },
        };
        public static List<Brand> Brands = new List<Brand>()
        {
            new Brand()
            {
                Id=1,
                Name="brand 1",
            },
            new Brand()
            {
                Id=2,
                Name="brand 2",
            },
            new Brand()
            {
                Id=3,
                Name="brand 3",
            },
        };
    }
}
