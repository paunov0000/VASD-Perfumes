using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Contracts;
using WebStore.Core.Model.Product;
using WebStore.Core.Services;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.UnitTests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private IRepository repo;
        private IProductService productService;
        private WebStoreDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<WebStoreDbContext>()
                .UseInMemoryDatabase("ProductDb")
                .Options;

            this.dbContext = new WebStoreDbContext(options);
            this.repo = new Repository(this.dbContext);

            this.productService = new ProductService(repo);

            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task AddProductAsync_ShouldAddProduct()
        {
            var productCategoryGuid = Guid.Parse("072a4bec-c3d3-4a66-aa9f-d3d7bc10d88e");
            var productGuid = Guid.Parse("072a4bec-c3d3-4a66-aa9f-d3d7bc10d88f");

            var product = new ProductAddViewModel()
            {
                Id = productGuid,
                Description = "Test Description",
                ImageUrl = "Test ImageUrl",
                Manufacturer = "Test Manufacturer",
                Name = "Test Name",
                Price = 100,
                ProductCategoryId = productCategoryGuid
            };

            await this.productService.AddProductAsync(product);

            var result = await this.repo.GetByIdAsync<Product>(productCategoryGuid);


            Assert.That(productCategoryGuid == result.ProductCategoryId);
            Assert.That(productGuid == result.Id);
            Assert.That("Test Description" == result.Description);
            Assert.That("Test ImageUrl" == result.ImageUrl);
            Assert.That("Test Manufacturer" == result.Manufacturer);
            Assert.That("Test Name" == result.Name);
            Assert.That(100 == result.Price);


        }

        [TearDown]
        public void TearDown()
        {
            this.dbContext.Dispose();
        }

    }
}
