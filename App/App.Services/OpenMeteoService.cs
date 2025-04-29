using App.Core.Interfaces;
using App.Core.Models;
using App.Core.Models.OpenMeteo;

namespace App.Services
{
    public class OpenMeteoService(HttpClient client) : ServiceBase, IWeatherForecastService
    {
        public async Task<RawWeatherForefast> GetBy(Location location)
            => await Get<RawWeatherForefast>(client, $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,wind_speed_10m&daily=temperature_2m_max,temperature_2m_mean,temperature_2m_min,apparent_temperature_max,apparent_temperature_mean,apparent_temperature_min,wind_speed_10m_max");
    }
}