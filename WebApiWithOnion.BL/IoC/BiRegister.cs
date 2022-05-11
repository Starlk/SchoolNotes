using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WebApiWithOnion.bl.IoC
{
    public static class BiRegister
    {
        public static void AddBiRegister(this IServiceCollection services, Assembly[] assemblies) 
        {
            services.AddAutoMapper(assemblies);
        }
    }
}
