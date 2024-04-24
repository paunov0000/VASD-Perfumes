//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Moq;
//using WebStore.Core.Contracts.Admin;
//using WebStore.Core.Services.Admin;
//using WebStore.Infrastructure.Common;
//using WebStore.Infrastructure.Data;

//namespace WebStore.UnitTests
//{
//    [TestFixture]
//    public class UserManageServiceTests
//    {
//        private IRepository repo;
//        private IUserManageService userManageService;
//        private WebStoreDbContext dbContext;


//        [SetUp]
//        public void Setup()
//        {
//            var options = new DbContextOptionsBuilder<WebStoreDbContext>()
//                .UseInMemoryDatabase("UserDb")
//                .Options;

//            this.dbContext = new WebStoreDbContext(options);
//            this.repo = new Repository(dbContext);

//            this.dbContext.Database.EnsureDeleted();

//            this.dbContext.Database.EnsureCreated();

//            this.userManageService = new UserManageService(repo, );
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            this.dbContext.Dispose();
//            this.repo.Dispose();
//        }

//        public static Mock<UserManager<TUser>> MockUserManager<TUser>(List<TUser> users)
//            where TUser : class
//        {
//            var store = new Mock<IUserStore<TUser>>();
//            var manager = new Mock<UserManager<TUser>>(store.Object);

//            manager.Object.UserValidators.Add(new UserValidator<TUser>());
//            manager.Object.PasswordValidators.Add(new PasswordValidator<TUser>());

//            manager.Setup(x => x.AddToRoleAsync(It.IsAny<TUser>(), It.IsAny<string>()));
//        }
//    }
//}
