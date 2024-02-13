using System.Text.Json.Serialization;

namespace TAX.Models
{
    public class TaxResponse
    {
        [JsonPropertyName("row")]
        public Tax Tax { get; set; }
    }
}