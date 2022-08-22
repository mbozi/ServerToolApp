using Microsoft.Extensions.DependencyInjection;
using ServerTool.Navigation;
using ServerTool.ViewModels;
using ServerTool.Views;

namespace ServerTool;

public static class RegisterServices
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        //services.AddSingleton<StoreModalCommandArgs>();

        //services.AddSingleton<DataStore>();

        services.AddSingleton<VModel<ViewModelFiles>>(services => { return () => services.GetRequiredService<ViewModelFiles>(); });
        services.AddSingleton<VModel<ViewModelSQL>>(services => { return () => services.GetRequiredService<ViewModelSQL>(); });


        services.AddSingleton<ViewModelFiles>();
        services.AddSingleton<ViewModelSQL>();

        services.AddSingleton<INavigationFactory, NavigationFactory>();
        services.AddSingleton<INavigationStore, NavigationStore>();

        services.AddSingleton<ViewModelMainWindow>();
        services.AddSingleton(s => new MainWindow(s.GetRequiredService<ViewModelMainWindow>()));

    }
}
