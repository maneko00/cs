using ODDD.Domain.Entities;

namespace ODDD.Domain.Repositories
{
    public interface IWeatherRepository
    {
        WeatherEntity GetData();
    }
}
