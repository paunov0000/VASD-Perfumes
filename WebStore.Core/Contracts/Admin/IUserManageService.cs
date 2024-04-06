using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Model.Admin.User;

namespace WebStore.Core.Contracts.Admin
{
    public interface IUserManageService
    {
        public Task<UserDetailsModel> GetUserByIdAsync(Guid id);

        public Task PromoteUserAsync(Guid id);

        public Task DemoteUserAsync(Guid id);

        public Task BanUserAsync(Guid id);

        public Task<IEnumerable<UserTableModel>> GetTableUsers(int count, string sort);
    }
}
