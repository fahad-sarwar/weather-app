using App.Core.Models.OpenMeteo;
using App.Core.Models.OpenStreetMap;

namespace App.Core.Models
{
    public class WeatherForecast
    {
        public Place Place { get; set; }
        public List<DailyForecast> DailyForecasts { get; set; }

        public static WeatherForecast From(RawPlace place)
            => new()
            {
                Place = Place.From(place)
            };

        public WeatherForecast SetMetrics(RawWeatherForefast rawWeatherForecast)
        {
            DailyForecasts = [];

            for(var index = 0; index < rawWeatherForecast.DailyMetrics.Dates.Count; index++)
            {
                var date = rawWeatherForecast.DailyMetrics.Dates[index];
                var maxTemp = rawWeatherForecast.DailyMetrics.MaxTemps[index];
                var meanTemp = rawWeatherForecast.DailyMetrics.MeanTemps[index];
                var minTemp = rawWeatherForecast.DailyMetrics.MinTemps[index];
                var windSpeed = rawWeatherForecast.DailyMetrics.WinSpeeds[index];

                DailyForecasts.Add(DailyForecast.From
                    (
                        date,
                        maxTemp,
                        meanTemp,
                        minTemp,
                        windSpeed,
                        rawWeatherForecast.DailyUnits
                    ));
            }

            return this;
        }
    }
}
