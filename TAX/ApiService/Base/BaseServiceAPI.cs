using System.Text.Json;

namespace TAX.ApiService.Base
{
    public abstract class BaseServiceAPI
    {
        public virtual async Task<T> GetResult<T>(HttpResponseMessage response)
        {
            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStreamAsync();
                    var result = await JsonSerializer.DeserializeAsync<T>(responseContent);

                    return result;
                }
                else
                {
                    throw new Exception($"Ошибка при обращении к серверу. \nЗапрос: {response.RequestMessage?.RequestUri}.\nСтатус код: {response.StatusCode}");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
