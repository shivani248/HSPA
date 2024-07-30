using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Model;


namespace WebAPI.Interfaces
{
    public interface InterfaceCityRepository
    {
         Task<IEnumerable<City>> GetCitiesAsync();
         void AddCity(City city);
         void DeleteCity(int CityId);
        //  Task<Boolean> SaveAsync();
        Task<City> FindCity(int id);
    }
}