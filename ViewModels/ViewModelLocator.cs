using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ViewModelLocator
    {
        private readonly IServiceProvider _serviceProvider;

        public ViewModelLocator()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider(new ServiceProviderOptions() { ValidateScopes = true, ValidateOnBuild = true });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MainViewModel>();
            services.AddSingleton<SingletonViewModel>();
            services.AddScoped<ScopedViewModel>();
            services.AddTransient<TransientViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get { return _serviceProvider.GetService<MainViewModel>()!; }
        }
    }
}
