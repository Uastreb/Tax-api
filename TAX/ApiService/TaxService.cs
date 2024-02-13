using TAX.ApiService.Base;
using TAX.Client;
using TAX.Models;
using TAX.Routes;

namespace TAX.ApiService
{
    public class TaxService : BaseServiceAPI, ITaxService
    {
        private readonly TaxClient _httpClient;

        public TaxService(TaxClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public async Task<Tax> GetTaxByUNP(string unp)
        {
            using (var response = await _httpClient.GetAsync(TaxRoutes.GetNameFromTaxByUNPRoute(unp)))
            {
                var taxResponse = await GetResult<TaxResponse>(response);

                return taxResponse.Tax;
            }
        }
    }
}
