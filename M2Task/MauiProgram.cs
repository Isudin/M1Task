using M2Task.Infrastructure;
using Microsoft.Extensions.Logging;

namespace M2Task;

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

         builder.Services.AddDbContext<TheOtherContext>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
