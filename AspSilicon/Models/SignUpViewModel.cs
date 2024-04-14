using AspSilicon.Filters;
using System.ComponentModel.DataAnnotations;

namespace AspSilicon.Models;

public class SignUpViewModel
{
    
    [Display(Name ="First name", Prompt ="Enter your first name")]
    [Required(ErrorMessage ="Enter a valid first name")]
    [MinLength(2, ErrorMessage = "Enter a valid first name")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "Enter a valid last name")]
    [MinLength(2, ErrorMessage = "Enter a valid last name")]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "Enter an valid email address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Enter a valid password")]
    [MinLength(8, ErrorMessage = "Enter a valid password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm Password", Prompt = "Confirm your password")]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Passwords don't match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "I agree to the Terms & Conditions.")]   
    [CheckboxRequired(ErrorMessage = "You must accept the terms and conditions")]
    public bool TermsAndConditions { get; set; } 
}
