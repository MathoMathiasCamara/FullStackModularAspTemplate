using Microsoft.Extensions.DependencyInjection;

namespace Asp.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            return services;
        }
    }
}
