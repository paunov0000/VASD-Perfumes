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

        //[Test]
        //public async Task AddProductAsync_ShouldAddProduct()
        //{
        //    var categoryGuid = Guid.Parse("072a4bec-c3d3-4a66-aa9f-d3d7bc10d88e");
        //    var brandGuid = Guid.Parse("df582419-a255-4774-8845-8cb094d59e78");
        //    var productGuid = Guid.Parse("072a4bec-c3d3-4a66-aa9f-d3d7bc10d88f");

        //    var product = new ProductAddViewModel()
        //    {
        //        Id = productGuid,
        //        Description = "Test Description",
        //        ImageUrl = "Test ImageUrl",
        //        BrandId = brandGuid,
        //        Name = "Test Name",
        //        Price = 100,
        //        CategoryId = categoryGuid
        //    };

        //    await this.productService.AddProductAsync(product);

        //    var result = await this.repo.GetByIdAsync<Product>(productGuid);


        //    Assert.That(categoryGuid == result.CategoryId);
        //    Assert.That(productGuid == result.Id);
        //    Assert.That("Test Description" == result.Description);
        //    Assert.That("Test ImageUrl" == result.ImageUrl);
        //    Assert.That(brandGuid == result.BrandId);
        //    Assert.That("Test Name" == result.Name);
        //    Assert.That(100 == result.Price);


        //}

        [Test]
        public async Task GetMostRecent_ShouldReturn3MostRecentProducts()
        {
            var result = await this.productService.GetMostRecent(3);

            Assert.That(result.Count(), Is.EqualTo(3));
        }


        [Test]
        public async Task GetMostRecent_ShouldReturnAllProductsWhenCountParamIsGreaterThanProductCount()
        {
            var countToBeExpected = this.dbContext.Products.Where(p => p.IsActive).Count();

            var result = await this.productService.GetMostRecent(100);

            Assert.That(result.Count(), Is.EqualTo(countToBeExpected));
        }


        [Test]
        public async Task GetMostRecent_ShouldReturnAnEmptyCollectionWhenCountIs0()
        {
            var result = await this.productService.GetMostRecent(0);

            Assert.That(result.Count(), Is.EqualTo(0));
        }


        [Test]
        public async Task GetAllProductsAsync_ShouldFetchAllProductsMarkedAsActive()
        {
            var expectedCount = this.dbContext.Products.Count(p => p.IsActive);

            //var totalCount = this.dbContext.Products.Count();

            var result = await this.productService.GetAllProductsAsync();

            Assert.That(expectedCount, Is.EqualTo(result.Count()));

            //Assert.That(totalCount, Is.Not.EqualTo(result.Count()));
        }


        [TearDown]
        public void TearDown()
        {
            this.dbContext.Dispose();
            this.repo.Dispose(); //TODO: why would I dispose it?
        }
    }
}
