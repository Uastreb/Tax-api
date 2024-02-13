using System.Text.Json.Serialization;

namespace TAX.Models
{
    public class Tax
    {
        /// <summary>
        /// Унп (192518385)
        /// </summary>
        [JsonPropertyName("vunp")]
        public string Unp { get; set; }

        /// <summary>
        /// Название (Общество с ограниченной ответственностью "СМБизнес")
        /// </summary>
        [JsonPropertyName("vnaimp")]
        public string Name { get; set; }

        /// <summary>
        /// Сокращенное название (ООО "СМБизнес")
        /// </summary>
        [JsonPropertyName("vnaimk")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        [JsonPropertyName("dreg")]
        public string Dreg { get; set; }

        /// <summary>
        /// Код инспекции МНС
        /// </summary>
        [JsonPropertyName("nmns")]
        public string Nmns { get; set; }

        /// <summary>
        /// Наименование инспекции МНС
        /// </summary>
        [JsonPropertyName("vmns")]
        public string Vmns { get; set; }

        /// <summary>
        /// Код состояния плательщика
        /// </summary>
        [JsonPropertyName("ckodsost")]
        public string Ckodsost { get; set; }

        /// <summary>
        /// Дата изменения состояния плательщика
        /// </summary>
        [JsonPropertyName("dlikv")]
        public object Dlikv { get; set; }

        /// <summary>
        /// Основание изменения состояния плательщика
        /// </summary>
        [JsonPropertyName("vlikv")]
        public object Vlikv { get; set; }
    }
}