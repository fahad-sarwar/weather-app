using App.Core.Models.OpenMeteo;

namespace App.Core.Models
{
    public class DailyForecast
    {
        public string Date { get; set; }
        public Metric MaxTemp {get;set; }
        public Metric MeanTemp { get; set; }
        public Metric MinTemp { get; set; }
        public Metric WindSpeed { get; set; }

        public static DailyForecast From(string date, double maxTemp, double meanTemp, double minTemp, double windSpeed, RawDailyUnits dailyUnits) 
            => new()
            {
                Date = date,
                MaxTemp = new Metric
                {
                    Value = maxTemp,
                    Unit = dailyUnits.TemperatureTwoMeterMaxUnit
                },
                MeanTemp = new Metric
                {
                    Value = meanTemp,
                    Unit = dailyUnits.TemperatureTwoMeterMeanUnit
                },
                MinTemp = new Metric
                {
                    Value = minTemp,
                    Unit = dailyUnits.TemperatureTwoMeterMinUnit
                },
                WindSpeed = new Metric
                {
                    Value = windSpeed,
                    Unit = dailyUnits.WindSpeedTenMeterMaxUnit
                }
            };
    }
}
