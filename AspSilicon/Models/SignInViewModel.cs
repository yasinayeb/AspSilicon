using System.ComponentModel.DataAnnotations;

namespace AspSilicon.Models;

public class SignInViewModel
{
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "Enter an valid email address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Enter a valid password")]
    [MinLength(8, ErrorMessage = "Enter a valid password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Remmember me.")]    
    public bool RemmemberMe { get; set; }
}
