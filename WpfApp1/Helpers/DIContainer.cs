using BOL.Abstractions;
using BOL.Services;
using DLL.Abstractions;
using DLL.Context;
using DLL.Models;
using DLL.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using WpfApp1.ViewModels.PageViewModels;
using WpfApp1.ViewModels.WindowViewModels;

namespace WpfApp1.Helpers
{
    public class DIContainer
    {
        public static ServiceProvider _provider;

        public static void Init()
        {
            var builder = new ServiceCollection();
            builder.AddScoped<AppDbContext>();

            builder.AddTransient<FormViewModel>();
            builder.AddTransient<AuthorizationViewModel>();
            builder.AddTransient<RegistrationViewModel>();
            builder.AddScoped<UserServices>();
            builder.AddScoped<IRepository<User>, UserRepository>();
            builder.AddScoped<GenericRepository<User>, UserRepository>();
            builder.AddSingleton<Navigation>();

            _provider = builder.BuildServiceProvider();
        }

        public FormViewModel FormViewModel => _provider.GetRequiredService<FormViewModel>();
        public AuthorizationViewModel AuthorizationViewModel => _provider.GetRequiredService<AuthorizationViewModel>();
        public RegistrationViewModel RegistrationViewModel => _provider.GetRequiredService<RegistrationViewModel>();


    }
}
