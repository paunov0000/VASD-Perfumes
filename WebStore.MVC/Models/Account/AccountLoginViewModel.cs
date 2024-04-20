using System.ComponentModel.DataAnnotations;
using static WebStore.Core.Constants.ErrorMessageConstants.General;
using static WebStore.Core.Constants.DisplayAttributeNameConstants.Account;

namespace WebStore.Models.Account
{
    public class AccountLoginViewModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [EmailAddress]
        [Display(Name = DisplayEmail)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = RequiredFieldMessage)]
        [DataType(DataType.Password)]
        [Display(Name = DisplayPassword)]
        public string Password { get; set; } = null!;

        [Display(Name = DisplayRememberMe)]
        public bool RememberMe { get; set; }
    }
}
