using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QDM.CMD.API.Model;

namespace QDM.CMD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get data from wheather
        /// </summary>
        /// <returns>List data wheather</returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// Insert wheather object
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Insert
        ///     {
        ///        "Date": "2020-09-12 15:17:22",
        ///        "TemperatureC": "100 oc",
        ///        "Summary": "Test current temp"
        ///     }
        ///
        /// </remarks>
        /// <returns>
        /// Status after insert wheather object
        /// </returns>
        [Route("Insert")]
        [HttpPost]
        public ResponseData Insert(WeatherForecast model)
        {
            var result = new ResponseData();

            // TODO: Code some thing here

            return result;
        }

        /// <summary>
        /// Search data from wheather
        /// </summary>
        /// <returns>List data wheather</returns>
        [HttpGet]
        [Route("Search")]
        public IEnumerable<WeatherForecast> Search([FromQuery]WeatherForecast model)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList().Take(model.TopResult).ToList();
        }



    }
}
