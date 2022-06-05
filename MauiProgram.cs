using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using DotNetMauiDrawingViewPaintAppSample.Views;
using MauiPaint;
using MauiPaint.Platforms.Services;
using MauiPaint.Serializer;
using MauiPaint.Services;

namespace DotNetMauiDrawingViewPaintAppSample;

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
		builder.UseMauiApp<App>().UseMauiCommunityToolkit();
		builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();

		builder.Services.AddSingleton<ISerializerService, JsonSerializerService>();
		builder.Services.AddSingleton(DeviceInfo.Current);
		builder.Services.AddSingleton<IDialogService, DialogService>();
		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}

