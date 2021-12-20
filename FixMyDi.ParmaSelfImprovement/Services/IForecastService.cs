using System.Collections;
using FixMyDi.ParmaSelfImprovement.Models;

namespace FixMyDi.ParmaSelfImprovement.Services
{
    /// <summary>
    /// Сервис для работы с прогнозами
    /// </summary>
    public interface IForecastService
    {
        /// <summary>
        /// Подготавливает прогноз
        /// </summary>
        public WeatherForecast PrepareForecast(int temperature);
    }
}