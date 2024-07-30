// using System.Collections.Generic;
// using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Interfaces;
using WebAPI.Model;


namespace WebAPI.Data.Repo
{
    public class CityRepo : InterfaceCityRepository
    {
        private readonly DataContext dc;

        public CityRepo(DataContext dc)
        {
            this.dc = dc;
        }
        public void AddCity(City city)
        {
            dc.Cities.Add(city);             
        }

        // public void AddCity(City city)
        // {
        //     throw new NotImplementedException();
        // }

        public void DeleteCity(int CityId)
        {
           var city =  dc.Cities.Find(CityId);
            if (city != null)
            {
                dc.Cities.Remove(city);
                
            }
            
        }

        public async Task<City> FindCity(int id)
        {
            var city = await dc.Cities.FindAsync(id);
            if (city == null)
            {
                // Handle the case where city is null
                throw new Exception("City not found");
            }
            return city;
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await dc.Cities.ToListAsync();
        }

        // public async Task<Boolean> SaveAsync(){
        //     return await dc.SaveChangesAsync()>0;
        // }

       

        //Task InterfaceCityRepository.SaveAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}