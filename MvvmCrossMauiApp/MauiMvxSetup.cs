using MvvmCross.IoC;
using MvvmCross.Platforms.Maui.Core;

namespace MvvmCrossMauiApp;

// Bootstraps MvvmCross inside .NET MAUI
public class MauiMvxSetup : MvxMauiSetup<App>
{
    protected override void RegisterDependencies(IMvxIoCProvider iocProvider)
    {
        base.RegisterDependencies(iocProvider);
        // register app services here
    }
}
