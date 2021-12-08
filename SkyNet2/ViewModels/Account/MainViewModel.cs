namespace SkyNet2.ViewModels.Account;

public class MainViewModel
{
    public MainViewModel()
    {
        RegisterView = new RegisterViewModel();
        LoginView = new LoginViewModel();
    }

    public RegisterViewModel RegisterView { get; set; }

    public LoginViewModel LoginView { get; set; }
}