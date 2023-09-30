using Microsoft.Extensions.Logging;
using SM.Mobile.Services.StartupHelpers;
using SM.Mobile.ViewModels;
using SM.Mobile.Views.Pages;

namespace SM.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //builder.Services.AddSingleton<ILogger>();
        //builder.Services.AddSingleton<ILoggerFactory>();

        builder.Services.AddSingleton<Main_Page>();
        builder.Services.AddSingleton<Login_Page>();
        builder.Services.AddFormFactory<MainPage_ViewModel>();
        builder.Services.AddFormFactory<Login_ViewModel>();
        builder.Services.AddFormFactory<Preferences_ViewModel>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
