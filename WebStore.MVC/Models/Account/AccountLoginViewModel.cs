using System.ComponentModel.DataAnnotations;
using static WebStore.Core.Constants.ErrorMessageConstants.General;
using static WebStore.Core.Constants.DisplayAttributeNameConstants.Account;

namespace WebStore.MVC.Models.Account
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
        [MinLength(6, ErrorMessage = "Test message for passwordlength")]
        public string Password { get; set; } = null!;

        [Display(Name = DisplayRememberMe)]
        public bool RememberMe { get; set; }
    }
}
