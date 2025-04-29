using System.Text.Json.Serialization;

namespace App.Core.Models.OpenMeteo
{
    public class RawDailyUnits
    {
        [JsonPropertyName("temperature_2m_max")]
        public string TemperatureTwoMeterMaxUnit { get; set; }

        [JsonPropertyName("temperature_2m_mean")]
        public string TemperatureTwoMeterMeanUnit { get; set; }

        [JsonPropertyName("temperature_2m_min")]
        public string TemperatureTwoMeterMinUnit { get; set; }

        [JsonPropertyName("wind_speed_10m_max")]
        public string WindSpeedTenMeterMaxUnit { get; set; }
    }
}
