using System.Text.Json.Serialization;

namespace App.Core.Models.OpenMeteo
{
    public class RawDailyMetrics
    {
        [JsonPropertyName("time")]
        public List<string> Dates { get; set; } = new();

        [JsonPropertyName("temperature_2m_max")]
        public List<double> MaxTemps { get; set; } = new();

        [JsonPropertyName("temperature_2m_mean")]
        public List<double> MeanTemps { get; set; } = new();

        [JsonPropertyName("temperature_2m_min")]
        public List<double> MinTemps { get; set; } = new();

        [JsonPropertyName("wind_speed_10m_max")]
        public List<double> WinSpeeds { get; set; } = new();
    }
}