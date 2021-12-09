using System.ComponentModel.DataAnnotations;

namespace SkyNet2.ViewModels.Account;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Display(Name = "Имя", Prompt = "Введите имя")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Display(Name = "Фамилия", Prompt = "Введите фамилию")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Display(Name = "Никнейм", Prompt = "Введите никнейм")]
    public string Login { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Display(Name = "Email", Prompt = "Введите email")]
    public string EmailReg { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Display(Name = "День", Prompt = "Введите день рождения")]
    public int Date { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Display(Name = "Месяц", Prompt = "Введите месяц рождения")]
    public int Month { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Display(Name = "Год", Prompt = "Введите год рождения")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль", Prompt = "Введите пароль")]
    [StringLength(100, ErrorMessage = "{0} должен иметь минимум {2} и максимум {1} символов", MinimumLength = 8)]
    public string PasswordReg { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [Compare("PasswordReg", ErrorMessage = "Пароли не совпадают")]
    [DataType(DataType.Password)]
    [Display(Name = "Подтвердите пароль", Prompt = "Введите пароль повторно")]
    public string PasswordConfirm { get; set; }
}