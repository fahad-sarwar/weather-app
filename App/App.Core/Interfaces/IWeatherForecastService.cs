using App.Core.Models;
using App.Core.Models.OpenMeteo;

namespace App.Core.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<RawWeatherForefast> GetBy(Location location);
    }
}
