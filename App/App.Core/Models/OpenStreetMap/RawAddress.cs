using System.Text.Json.Serialization;

namespace App.Core.Models.OpenStreetMap
{
    public class RawAddress
    {
        [JsonPropertyName("town")]
        public string Town { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        public bool IsUnitedKingdomAddress() =>
            string.Equals(CountryCode, "GB", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(CountryCode, "GBR", StringComparison.OrdinalIgnoreCase);
    }
}
