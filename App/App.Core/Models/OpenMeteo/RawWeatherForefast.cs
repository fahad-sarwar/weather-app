using System.Text.Json.Serialization;

namespace App.Core.Models.OpenMeteo
{
    public class RawWeatherForefast
    {
        [JsonPropertyName("daily_units")]
        public RawDailyUnits DailyUnits { get; set; }

        [JsonPropertyName("daily")]
        public RawDailyMetrics DailyMetrics { get; set; }
    }
}