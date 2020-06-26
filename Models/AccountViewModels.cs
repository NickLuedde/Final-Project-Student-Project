using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GAG_101.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterBusinessUserViewModel
    {

        [Required]
        [Display(Name = "What's Your Name?")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "What's Your Business Name?")]
        public string BusinessName { get; set; }

        [Required]
        [Display(Name = "What's Your Federal Tax ID # ?")]
        public string FEIN { get; set; }

        [Required]
        [Display(Name = "What's Your Zip Code?")]
        public int Zip { get; set; }

        [Required]
        [Display(Name = "What's Your Phone Number")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "What's Your Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Please Enter A Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Your Password")]
        [Compare("Password", ErrorMessage = "I'm sorry...It appears The password you entered and the confirmation password aren't a match.")]
        public string ConfirmPassword { get; set; }


    }

    public class RegisterExpertViewModel
    {
        [Required]
        [Display(Name = "What's Your Name?")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "What's Your Business Name?")]
        public string BusinessName { get; set; }

        [Required]
        [Display(Name = "What's Your Federal Tax ID # ?")]
        public string BU_FEIN { get; set; }

        [Required]
        [Display(Name = "What's Your Service Do You Provide?")]
        public string Name_JobType { get; set; }

        [Required]
        [Display(Name = "What's Your Zip Code?")]
        public int Location_Zip { get; set; }

        [Required]
        [Display(Name = "What's Your Phone Number")]
        public string Phone_Number { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "What's Your Email")]
        public string Email { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
