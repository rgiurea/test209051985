namespace MauiSplashTemplate;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
    }
}
