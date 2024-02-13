using Microsoft.Extensions.DependencyInjection;
using TAX.ApiService;
using TAX.Client;

namespace TAX
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddTaxService(this IServiceCollection services)
        {
            services.AddHttpClient<TaxClient>(c => c.BaseAddress = new Uri("http://grp.nalog.gov.by/"));

            services.AddScoped<ITaxService, TaxService>();

            return services;
        }
    }
}