using System.ComponentModel.DataAnnotations;

namespace SkyNet2.ViewModels.Account;

public class LoginViewModel
{
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [EmailAddress]
    [Display(Name = "Email", Prompt = "Введите email")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль", Prompt = "Введите пароль")]
    public string? Password { get; set; }

    [Display(Name = "Запомнить?")]
    public bool RememberMe { get; set; }

    public string? ReturnUrl { get; set; }
}