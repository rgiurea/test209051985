using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossMauiApp.ViewModels;

public class HomeViewModel : MvxViewModel
{
    private readonly IMvxNavigationService _navigation;

    public HomeViewModel(IMvxNavigationService navigation)
    {
        _navigation = navigation;
        ShowDetailsCommand = new MvxAsyncCommand(() => _navigation.Navigate<DetailsViewModel, ItemParams>(new ItemParams { ItemId = 42 }));
        ShowSettingsCommand = new MvxAsyncCommand(() => _navigation.Navigate<SettingsViewModel>());
        ShowAboutCommand = new MvxAsyncCommand(() => _navigation.Navigate<AboutViewModel>());
        LogoutCommand = new MvxAsyncCommand(() => _navigation.Navigate<LoginViewModel>(new MvxNavigationOptions { ClearNavigationStack = true }));
    }

    public IMvxAsyncCommand ShowDetailsCommand { get; }
    public IMvxAsyncCommand ShowSettingsCommand { get; }
    public IMvxAsyncCommand ShowAboutCommand { get; }
    public IMvxAsyncCommand LogoutCommand { get; }

    public override Task<bool> CanClose() => Task.FromResult(true);
}
