using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossMauiApp.ViewModels;

// Deep link route: myapp://details/{ItemId}
[MvvmCross.Navigation.MvxRoute("details/{ItemId}")]
public class DetailsViewModel : MvxViewModel<ItemParams>
{
    private readonly IMvxNavigationService _navigation;

    public DetailsViewModel(IMvxNavigationService navigation)
    {
        _navigation = navigation;
        OpenSubDetailsCommand = new MvxAsyncCommand(() => _navigation.Navigate<SubDetailsViewModel>());
        BackCommand = new MvxAsyncCommand(() => _navigation.Close(this));
    }

    public int ItemId { get; private set; }

    public IMvxAsyncCommand OpenSubDetailsCommand { get; }
    public IMvxAsyncCommand BackCommand { get; }

    public override void Prepare(ItemParams parameter)
    {
        ItemId = parameter.ItemId;
    }

    public override Task<bool> CanClose() => Task.FromResult(true);
}
