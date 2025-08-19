using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossMauiApp.ViewModels;

public class RegisterViewModel : MvxViewModel
{
    private readonly IMvxNavigationService _navigation;

    public RegisterViewModel(IMvxNavigationService navigation)
    {
        _navigation = navigation;
        BackCommand = new MvxAsyncCommand(() => _navigation.Close(this));
    }

    public IMvxAsyncCommand BackCommand { get; }

    public override Task<bool> CanClose() => Task.FromResult(true);
}
