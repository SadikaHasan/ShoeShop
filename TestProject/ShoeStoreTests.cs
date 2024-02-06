using Moq;
using ShoeStore.BL.Interfaces;
using ShoeStore.BL.Services;
using ShoeStore.DL.Interfaces;
using ShoeStore.DL.Repository;
using ShoeStore.Models.models;
using ShoeStore.Models.Requests;
using ShoeStore.Models.Responses;

namespace TestProject
{
    public class ShoeStoreTests
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

        [Fact]
        public void ChectCountOfShoes_OK()
        {
            var input = 5;
            var expectedCount = 3; 
            var mockedShoeRepository = new Mock<IShoeRepository>();
            mockedShoeRepository.Setup(x => x.GetAllShoes()).Returns(Shoes);

            var mockedBrandRepository = new Mock<IBrandRepository>();
            mockedBrandRepository.Setup(x => x.GetAllBrands()).Returns(BrandsData);

            var shoeService = new ShoeService(mockedShoeRepository.Object);
            var brandService = new BrandService(mockedBrandRepository.Object); 
            var service = new StoreService(brandService, shoeService);

            // Act
            var result = service.CheckShoeCount();

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllByBrandsAfterReleaseDate_ReturnsCorrectResponse()
        {
            // Arrange
            var brandId = 1;
            var dateAfter = new DateTime(2023, 1, 1);
            var request = new GetAllShoesByBrandRequest { BrandId = brandId, DateAfter = dateAfter };

            var mockBrandService = new Mock<IBrandService>();
            mockBrandService.Setup(x => x.GetBrand(brandId)).Returns(new Brand { Id = brandId });

            var mockShoeService = new Mock<IShoeService>();
            mockShoeService.Setup(x => x.GetAllByBrandsAfterReleaseDate(brandId, dateAfter)).Returns(new List<Shoe> { new Shoe(), new Shoe() });

            var storeService = new StoreService(mockBrandService.Object, mockShoeService.Object);

            // Act
            var result = storeService.GetAllByBrandsAfterReleaseDate(request);

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Brand);
            Assert.Equal(brandId, result.Brand.Id);
            Assert.NotNull(result.Shoe);
            Assert.Equal(2, result.Shoe.Count);
        }

        [Fact]
        public void GetAllShoesByBrandAfterReleaseDate_ReturnsCorrectResponse()
        {
            // Arrange
            var brandId = 1;
            var dateAfter = new DateTime(2023, 1, 1);
            var request = new GetAllShoesByBrandRequest { BrandId = brandId, DateAfter = dateAfter };
            var expectedResponse = new GetAllShoesByBrandResponse
            {
                Brand = new Brand { Id = brandId, Name = "ShoeStoreTests Brand" },
                Shoe = new List<Shoe> { new Shoe { Id = 1, Size = 42 }, new Shoe { Id = 2, Size = 40 } }
            };

            var mockBrandService = new Mock<IBrandService>();
            mockBrandService.Setup(x => x.GetBrand(brandId)).Returns(expectedResponse.Brand);

            var mockShoeService = new Mock<IShoeService>();
            mockShoeService.Setup(x => x.GetAllByBrandsAfterReleaseDate(brandId, dateAfter)).Returns(expectedResponse.Shoe);

            var storeService = new StoreService(mockBrandService.Object, mockShoeService.Object);

            // Act
            var result = storeService.GetAllShoesByBrandAfterReleaseDate(request);

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Brand);
            Assert.Equal(expectedResponse.Brand.Id, result.Brand.Id);
            Assert.Equal(expectedResponse.Brand.Name, result.Brand.Name);
            Assert.NotNull(result.Shoe);
            Assert.Equal(expectedResponse.Shoe.Count, result.Shoe.Count);
            Assert.Collection(result.Shoe,
                shoe => Assert.Equal(expectedResponse.Shoe[0].Id, shoe.Id),
                shoe => Assert.Equal(expectedResponse.Shoe[1].Id, shoe.Id)
            );
        }
    }    
}