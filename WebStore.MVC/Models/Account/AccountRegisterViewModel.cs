using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static WebStore.Core.Constants.ErrorMessageConstants.General;
using static WebStore.Core.Constants.ErrorMessageConstants.Account;
using static WebStore.Core.Constants.DisplayAttributeNameConstants.Account;

namespace WebStore.Models.Account
{
    public class AccountRegisterViewModel : AccountLoginViewModel
    {
        [Required(ErrorMessage = RequiredFieldMessage)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = PasswordsDoNotMatchMessage)]
        [Display(Name = DisplayConfirmPassword)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
