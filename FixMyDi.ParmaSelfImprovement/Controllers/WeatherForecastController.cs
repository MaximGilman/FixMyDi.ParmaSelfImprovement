using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FixMyDi.ParmaSelfImprovement.Models;
using FixMyDi.ParmaSelfImprovement.Services;

namespace FixMyDi.ParmaSelfImprovement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IForecastService _forecastService;

        public WeatherForecastController(ForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        /// <summary>
        /// Проверяет работоспособность контролера
        /// </summary>
        public string Ping()
        {
            return "Alive";
        }

        /// <summary>
        /// Подготавливает прогноз и выводит результат
        /// </summary>
        [HttpPost("Run")]
        public WeatherForecast PrepareForecastAndGetResult([FromBody] int temperature)
        {
            return _forecastService.PrepareForecast(temperature);
        }
    }
}