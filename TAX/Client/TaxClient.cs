namespace TAX.Client
{
    public class TaxClient
    {
        private readonly HttpClient _httpClient;

        public TaxClient(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            var response = await _httpClient.GetAsync(uri);

            return response;
        }
    }
}
