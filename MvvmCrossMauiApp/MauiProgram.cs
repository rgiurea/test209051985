using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using MvvmCross.Platforms.Maui.Core;

namespace MvvmCrossMauiApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiMvx<MauiMvxSetup>();
        return builder.Build();
    }
}
