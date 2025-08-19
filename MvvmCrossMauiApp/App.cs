using MvvmCross.ViewModels;
using MvvmCrossMauiApp.ViewModels;

namespace MvvmCrossMauiApp;

// MvvmCross application entry point. Registers the initial navigation.
public class App : MvxApplication
{
    public override void Initialize()
    {
        RegisterAppStart<SplashViewModel>();
    }
}
