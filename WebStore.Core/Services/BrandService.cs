using Microsoft.EntityFrameworkCore;
using WebStore.Core.Contracts;
using WebStore.Core.Model.Brand;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Services
{
    public class BrandService : IBrandService
    {
        private readonly IRepository repo;

        public BrandService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<HomeBrandViewModel>> GetHomeBrands(int count)
        {
            return await repo.AllReadonly<Brand>()
                .Take(count)
                .Select(b => new HomeBrandViewModel()
                {
                    Id = b.Id,
                    ImageUrl = b.ImageUrl,
                })
                .ToListAsync();
        }
    }
}
