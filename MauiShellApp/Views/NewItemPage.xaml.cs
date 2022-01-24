using MauiShellApp.Models;
using MauiShellApp.ViewModels;

namespace MauiShellApp.Views;

public partial class NewItemPage : ContentPage
{
    public Item Item { get; set; }

    public NewItemPage()
    {
        InitializeComponent();
        BindingContext = new NewItemViewModel();
    }
}
