using Microsoft.EntityFrameworkCore;
using WebStore.Core.Contracts;
using WebStore.Core.Services;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data;

using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Product;

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

            var result = await this.productService.GetAllProductsAsync();

            Assert.That(expectedCount, Is.EqualTo(result.Count()));
        }

        [Test]
        public async Task GetMostSold_ShouldFetchCountMostSoldProducts()
        {
            var count = 7;
            var expectedList = await this.dbContext.Products
                .OrderBy(p => p.SoldCount)
                .Take(count)
                .ToListAsync();

            var result = await this.productService.GetMostSold(count);

            Assert.That(result.Count(), Is.EqualTo(count));
            Assert.That(result.Count(), Is.EqualTo(expectedList.Count));
        }

        [Test]
        public async Task GetOnSale_ShouldFetchCountActiveProductsWhichAreOnSale()
        {
            var productCountToFetch = 3;

            var expectedList = await this.dbContext.Products
                .Where(p => p.IsActive && p.OnSale)
                .Take(productCountToFetch)
                .ToListAsync();

            var resultList = await this.productService.GetOnSale(productCountToFetch);

            Assert.That(resultList.Count(), Is.EqualTo(expectedList.Count));
        }

        [Test]
        public async Task GetProductsByName_ShouldFetchAllActiveProductsWhichNamesStartsWith()
        {
            var search = "bl";

            var expectedList = await this.dbContext.Products
                .Where(p => p.Name.StartsWith(search) && p.IsActive)
                .ToListAsync();

            var resultList = await this.productService.GetProductsByName(search);

            Assert.That(resultList.Count(), Is.EqualTo(expectedList.Count));
            Assert.That(resultList.All(p => p.Name.StartsWith(search)));
        }

        [Test]
        public async Task GetProductByIdAsync_ShouldReturnAProductByGivenId()
        {
            var guid = Guid.Parse(AventusByCreedId);

            var expected = await this.dbContext.Products.FindAsync(guid);

            var result = await this.productService.GetProductByIdAsync(guid);

            Assert.That(result.Id, Is.EqualTo(guid));
            Assert.That(result.Id, Is.EqualTo(expected.Id));
            Assert.That(result.Name, Is.EqualTo(expected.Name));
        }

        [Test]
        public async Task GetProductDetailsById_ShouldReturnAProductByGivenId()
        {
            var guid = Guid.Parse(Chanel05Id);

            var expected = await this.dbContext.Products.FindAsync(guid);

            var result = await this.productService.GetProductDetailsById(guid);

            Assert.That(result.Id, Is.EqualTo(guid));
            Assert.That(result.Id, Is.EqualTo(expected.Id));
            Assert.That(result.Name, Is.EqualTo(expected.Name));
        }

        [Test]
        public void GetProductDetailsById_ShouldThrowAnInvalidOperationExcepionWhenEntityIsNotFound()
        {
            var guid = Guid.Parse("36e440a2-1a96-4756-83c3-0f7bfb5b285b");

            var ex = Assert.ThrowsAsync<InvalidOperationException>(async () => await this.productService.GetProductDetailsById(guid));

            Assert.That(ex.Message, Is.EqualTo("Entity not found"));

        }

        [Test]
        public async Task GetProductCartModelById_ShouldReturnAProductByGivenId()
        {
            var guid = Guid.Parse(TerreDhermesByHermesId);

            var expected = await this.dbContext.Products.FindAsync(guid);

            var result = await this.productService.GetProductCartModelById(guid);

            Assert.That(result.Id, Is.EqualTo(guid));
            Assert.That(result.Id, Is.EqualTo(expected.Id));
            Assert.That(result.Name, Is.EqualTo(expected.Name));
            Assert.That(result.Price, Is.EqualTo(expected.Price));
            Assert.That(result.Quantity, Is.EqualTo(expected.Quantity));
        }

        [Test]
        public void GetProductCartModelById_ShouldThrowAnInvalidOperationExceptionWhenEntityIsNotFound()
        {
            var guid = Guid.Parse("36e440a2-1a96-4756-83c3-0f7bfb5b285b");

            var ex = Assert.ThrowsAsync<InvalidOperationException>(async () => await this.productService.GetProductCartModelById(guid));

            Assert.That(ex.Message, Is.EqualTo("Entity not found"));
        }

        [TearDown]
        public void TearDown()
        {
            this.dbContext.Dispose();
            this.repo.Dispose(); //TODO: why would I dispose it?
        }
    }
}
