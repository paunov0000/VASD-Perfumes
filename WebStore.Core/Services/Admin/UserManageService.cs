using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data.Entities;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Admin.User;
using WebStore.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Core.Services.Admin
{
    public class UserManageService : IUserManageService
    {
        private readonly IRepository repo;
        private readonly UserManager<ApplicationUser> userManager;

        public UserManageService(IRepository _repo,
                UserManager<ApplicationUser> _userManager)
        {
            repo = _repo;
            userManager = _userManager;
        }

        public async Task BanUserAsync(Guid id)
        {
            var entity = await repo.GetByIdAsync<ApplicationUser>(id);

            var result = await userManager.SetLockoutEndDateAsync(entity, new DateTimeOffset(DateTime.UtcNow.AddDays(365)));

            //TODO: do i have to save changes here???
        }

        public async Task DemoteUserAsync(Guid id)
        {
            var entity = await repo.GetByIdAsync<ApplicationUser>(id);

            var result = await userManager.RemoveFromRoleAsync(entity, "VIP");

            //TODO: do i have to save changes here??
        }

        public async Task<IEnumerable<UserTableModel>> GetAllUsersAsync()
        {
            return await repo.AllReadonly<ApplicationUser>()
                .Select(u => new UserTableModel()
                {
                    Id = u.Id,
                    Name = $"{u.FirstName} {u.LastName}",
                    Email = u.Email,
                    UserName = u.UserName,
                    PhoneNumber = u.PhoneNumber
                })
                .ToListAsync();
        }

        public async Task<UserDetailsModel> GetUserByIdAsync(Guid id)
        {
            var entity = await repo.GetByIdAsync<ApplicationUser>(id);

            return new UserDetailsModel()
            {
                Id = entity.Id,
                UserName = entity.UserName
            };
        }

        public async Task PromoteUserAsync(Guid id)
        {
            var entity = await repo.GetByIdAsync<ApplicationUser>(id);

            var result = await userManager.AddToRoleAsync(entity, "VIP");

            //TODO: do i have to save changes here??
        }
    }
}
