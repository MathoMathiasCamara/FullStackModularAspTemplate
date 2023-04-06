using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Asp.Api
{
    public static class MyApiServiceCollection
    {

        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Asp.Api", Version = "v1" });
            });
            return services;
        }
    }
}
