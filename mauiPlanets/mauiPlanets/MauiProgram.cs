using Microsoft.Extensions.Logging;

namespace mauiPlanets
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Montserrat-Medium.ttf", "RegularFont");
                    fonts.AddFont("Montserrat-Medium.ttf", "MediumFont");
                    fonts.AddFont("Montserrat-Medium.ttf", "BoldFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
