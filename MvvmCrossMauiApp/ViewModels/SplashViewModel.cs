using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossMauiApp.ViewModels;

public class SplashViewModel : MvxViewModel
{
    private readonly IMvxNavigationService _navigation;

    public SplashViewModel(IMvxNavigationService navigation)
    {
        _navigation = navigation;
    }

    public override async Task Initialize()
    {
        await base.Initialize();
        // Replace the navigation stack with Login
        await _navigation.Navigate<LoginViewModel>(new MvxNavigationOptions { ClearNavigationStack = true });
    }
}
