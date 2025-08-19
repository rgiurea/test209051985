using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossMauiApp.ViewModels;

public class LoginViewModel : MvxViewModel
{
    private readonly IMvxNavigationService _navigation;

    public LoginViewModel(IMvxNavigationService navigation)
    {
        _navigation = navigation;
        GoHomeCommand = new MvxAsyncCommand(() => _navigation.Navigate<HomeViewModel>(new MvxNavigationOptions { ClearNavigationStack = true }));
        GoRegisterCommand = new MvxAsyncCommand(() => _navigation.Navigate<RegisterViewModel>());
    }

    public IMvxAsyncCommand GoHomeCommand { get; }
    public IMvxAsyncCommand GoRegisterCommand { get; }

    public override Task<bool> CanClose() => Task.FromResult(true);
}
