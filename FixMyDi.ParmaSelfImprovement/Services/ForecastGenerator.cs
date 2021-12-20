using System;
using FixMyDi.ParmaSelfImprovement.Models;

namespace FixMyDi.ParmaSelfImprovement.Services
{
    /// <summary>
    /// Сервис для генерации данных
    /// </summary>
    public class ForecastGenerator
    {
        /// <summary>
        /// Создание прогноза с указанной температурой
        /// </summary>
        public WeatherForecast Generate(int temperature)
            => new WeatherForecast()
            {
                Date = DateTime.Now,
                Summary = "Мой прогноз",
                TemperatureC = temperature
            };
    }
}