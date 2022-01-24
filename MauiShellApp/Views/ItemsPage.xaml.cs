using MauiShellApp.ViewModels;

namespace MauiShellApp.Views;

public partial class ItemsPage : ContentPage
{
    ItemsViewModel _viewModel;

    public ItemsPage()
    {
        InitializeComponent();

        BindingContext = _viewModel = new ItemsViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }
}
