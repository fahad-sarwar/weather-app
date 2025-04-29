using App.Core.Interfaces;
using App.Core.Models;

namespace App.Core
{
    public class WeatherForecastManager(IPlaceService placeService, IWeatherForecastService weatherForecastService)
    {
        public async Task<WeatherForecast> Get(string town)
        {
            var rawPlace = await placeService.Search(town);
            
            var weatherForecast = WeatherForecast.From(rawPlace.First(p => p.IsUnitedKingdomAddress()));

            var rawWeatherForecast = await weatherForecastService.GetBy(weatherForecast.Place.Location);

            return weatherForecast
                .SetMetrics(rawWeatherForecast);
        }
    }
}