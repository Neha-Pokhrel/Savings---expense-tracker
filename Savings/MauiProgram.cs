﻿using Microsoft.Extensions.Logging;
using Savings.Services.Interface;
using Savings.Services;
using MudBlazor.Services;

namespace Savings
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
            builder.Services.AddScoped<IUserInteface, UserService>();
           

            builder.Services.AddMudServices();

#endif

            return builder.Build();
        }
    }
}
