using MauiShellApp.ViewModels;

namespace MauiShellApp.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        this.BindingContext = new LoginViewModel();
    }
}
