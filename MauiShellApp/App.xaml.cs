using MauiShellApp.Services;

namespace MauiShellApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		DependencyService.Register<MockDataStore>();
		MainPage = new AppShell();
	}
}
