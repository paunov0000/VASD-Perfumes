using Microsoft.AspNetCore.Identity;
using WebStore.Core.Contracts;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Misc;
using WebStore.Core.Services;
using WebStore.Core.Services.Admin;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data;
using WebStore.Infrastructure.Data.Entities;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WebStoreServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductManageService, ProductManageService>();
            services.AddScoped<IUserManageService, UserManageService>();
            services.AddScoped<IOrderManageService, OrderManageService>();
            services.AddScoped<IBrandService, BrandService>();

            return services;
        }

        public static IdentityBuilder AddApplicationIdentity<TUser>(this IServiceCollection services, IConfiguration configuration) where TUser : class
        {
            services.AddDefaultIdentity<TUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                options.SignIn.RequireConfirmedEmail = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedEmail");
                options.SignIn.RequireConfirmedPhoneNumber = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedPhoneNumber");
                options.Password.RequiredLength = configuration.GetValue<int>("Identity:Password:RequiredLength");
                options.Password.RequireNonAlphanumeric = configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                options.Password.RequireUppercase = configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequireLowercase = configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireDigit = configuration.GetValue<bool>("Identity:Password:RequireDigit");
            })
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<WebStoreDbContext>()
                .AddDefaultTokenProviders()
                .AddUserManager<UserManager<TUser>>()
                .AddErrorDescriber<CustomIdentityErrorDescriber>();

            return new IdentityBuilder(typeof(TUser), services);
        }
    }
}
