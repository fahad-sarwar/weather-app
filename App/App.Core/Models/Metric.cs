namespace App.Core.Models
{
    public class Metric
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public string Description => $"{Value} {Unit}";
    }
}
