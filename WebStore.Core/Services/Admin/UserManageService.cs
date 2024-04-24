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

        public async Task<IEnumerable<UserTableModel>> GetTableUsers(int count, string sort)
        {
            IQueryable<ApplicationUser> model;

            if (count == 0)
            {
                model = repo.AllReadonly<ApplicationUser>();
            }
            else
            {
                model = repo.AllReadonly<ApplicationUser>().Take(count);
            }


            model = sort switch
            {
                "email-asc" => model.OrderBy(p => p.Email),
                "email-desc" => model.OrderByDescending(p => p.Email),
                "phoneNumber-f" => model.OrderBy(p => p.PhoneNumber != null),
                "phoneNumber-t" => model.OrderByDescending(p => p.PhoneNumber != null),
                _ => model.OrderBy(p => p.Email),
            };

            var users = await model.ToListAsync();


            var result = new List<UserTableModel>();

            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);

                result.Add(new UserTableModel()
                {
                    Id = user.Id,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Roles = roles
                });

                if (roles.Count == 0)
                {
                    roles.Add("User");
                }
            }

            return result;

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
