using SM.Mobile.Services.StartupHelpers.Abstract;

namespace SM.Mobile.Services.StartupHelpers;
public static class ServiceExtensions
{
    public static void AddFormFactory<TForm>(this IServiceCollection services) where TForm : class
    {
        services.AddTransient<TForm>();
        services.AddSingleton<Func<TForm>>(x => () => x.GetService<TForm>()!);
        services.AddSingleton<IAbstractFactory<TForm>, AbstractFactory<TForm>>();
    }
}
