using ImageSeeker.Data.DirectoryTreeDialog;
using ImageSeeker.Data.File;
using Radzen;

namespace ImageSeeker;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddScoped<DialogService>();
        builder.Services.AddScoped<IDirectoryTreeDialogService, DirectoryTreeDialogService>();
        builder.Services.AddScoped<IFileSearchService, FileSearchService>();
        builder.Services.AddScoped<IFileMoveService, FileMoveService>();
        
        return builder.Build();
    }
}