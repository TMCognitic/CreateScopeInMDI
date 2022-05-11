using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class MainViewModel
    {
        private static int _instanceCount;
        public IServiceProvider ServiceProvider { get; init; }
        public string Name { get; set; }

        public MainViewModel(IServiceScopeFactory serviceScopeFactory)
        {
            _instanceCount++;
            Name = $"{GetType().Name}{_instanceCount:D2}";
            ServiceProvider = serviceScopeFactory.CreateScope().ServiceProvider;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} HashCode : {GetHashCode()}");
            sb.AppendLine($"Singleton inside {Name} HashCode : {ServiceProvider.GetService<SingletonViewModel>()!.GetHashCode()}");
            sb.AppendLine($"Scoped inside {Name} HashCode : {ServiceProvider.GetService<ScopedViewModel>()!.GetHashCode()}");
            sb.AppendLine($"Transient inside {Name} HashCode : {ServiceProvider.GetService<TransientViewModel>()!.GetHashCode()}");
            return sb.ToString();
        }
    }
}
