using WebStore.Core.Model.Brand;

namespace WebStore.Core.Contracts
{
    public interface IBrandService
    {
        public Task<IEnumerable<HomeBrandViewModel>> GetHomeBrands(int count);
    }
}
