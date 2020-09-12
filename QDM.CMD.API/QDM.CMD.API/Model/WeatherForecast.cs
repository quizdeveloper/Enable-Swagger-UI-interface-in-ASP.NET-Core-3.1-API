using System;
using System.ComponentModel.DataAnnotations;

namespace QDM.CMD.API
{
    public class WeatherForecast
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int TemperatureC { get; set; }

        [Required]
        public int TopResult { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
