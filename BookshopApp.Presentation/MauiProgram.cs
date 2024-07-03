using BookshopApp.Application.Services;
using BookshopApp.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using BookshopApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookshopApp.Presentation;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

        // Register dependencies
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=bookshop.db"));
        builder.Services.AddScoped<IBookRepository, BookRepository>();
        builder.Services.AddScoped<BookService>();

        return builder.Build();
	}
}
