using Microsoft.Extensions.Logging;
using MPowerKit.Navigation;
using MPowerKit.Navigation.Popups;
using MPowerKit.Navigation.Utilities;

namespace PopupProblems;

public static class MauiProgramExtensions
{
    public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
    {
        builder
            .UseMauiApp<App>()
            .UseMPowerKitNavigation(mvvmBuilder => mvvmBuilder
                .UsePopupNavigation()
                .OnAppStart("/NavigationPage/MainPage")
                .ConfigureServices(collection => collection
                    .RegisterForNavigation<MainPage, MainViewModel>()
                    .RegisterForNavigation<NotificationPopupPage>()
                    .RegisterForNavigation<SomePage, SomeViewModel>()
                    .RegisterForNavigation<SimplePopupPage, SimpleViewModel>()))
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder;
    }
}