using System.Text.Json.Serialization;

namespace App.Core.Models.OpenStreetMap
{
    public class RawPlace
    {
        [JsonPropertyName("place_id")]
        public int PlaceId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        [JsonPropertyName("address")]
        public RawAddress Address { get; set; }

        public bool IsUnitedKingdomAddress() => Address.IsUnitedKingdomAddress();
    }
}
