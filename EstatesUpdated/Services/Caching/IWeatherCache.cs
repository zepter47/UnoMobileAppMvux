namespace EstatesUpdated.Services.Caching;
using WeatherForecast = EstatesUpdated.DataContracts.WeatherForecast;
public interface IWeatherCache
{
    ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
}
