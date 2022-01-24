using MauiShellApp.ViewModels;

namespace MauiShellApp.Views;

public partial class ItemDetailPage : ContentPage
{
    public ItemDetailPage()
    {
        InitializeComponent();
        BindingContext = new ItemDetailViewModel();
    }
}
