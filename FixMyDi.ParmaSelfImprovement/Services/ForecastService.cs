using FixMyDi.ParmaSelfImprovement.Models;

namespace FixMyDi.ParmaSelfImprovement.Services
{
    /// <inheritdoc />
    public class ForecastService : IForecastService
    {
        private readonly ForecastGenerator _generator;

        public ForecastService(ForecastGenerator generator)
        {
            _generator = generator;
        }

        public WeatherForecast PrepareForecast(int temperature)
            => _generator.Generate(temperature);
    }
}