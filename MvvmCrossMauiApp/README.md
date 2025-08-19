# MvvmCrossMauiApp

Placeholder .NET 9 MAUI app using MvvmCross for navigation and MVVM.

## Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/)
- .NET MAUI workloads for Android and iOS (`dotnet workload install maui`)
- Android/iOS tooling as required by MAUI

## Build and Run
```
# Android
dotnet build -t:Run -f net9.0-android MvvmCrossMauiApp.csproj

# iOS
dotnet build -t:Run -f net9.0-ios MvvmCrossMauiApp.csproj
```

## Navigation
- SplashView -> automatically navigates to LoginView.
- LoginView buttons navigate to HomeView or RegisterView.
- RegisterView closes back to LoginView.
- HomeView navigates to Details, Settings, About, or logs out.
- DetailsView accepts an `ItemId` parameter and can open SubDetails or go back.
- Back commands call `_navigation.Close(this)` and hardware back uses `CanClose` overrides.

### Deep Link
The app exposes a deep link to `DetailsView` with an `ItemId`.

- Android test:
  ```bash
  adb shell am start -a android.intent.action.VIEW -d "myapp://details/42"
  ```
- iOS test (simulator):
  ```bash
  xcrun simctl openurl booted "myapp://details/42"
  ```

The parameter is bound in `DetailsViewModel`.
