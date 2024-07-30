using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;
using WebAPI;
using WebAPI.Interfaces;
using WebAPI.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using WebAPI.Controllers.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers
{
    [Authorize]
   
    public class CityController : BaseController
    {
        private object cityfromDb;

        // private readonly DataContext dc;
        // private readonly InterfaceCityRepository repo;

        public InterfaceUnitofWork uow { get; }
        public IMapper Mapper { get; }

        public CityController(InterfaceUnitofWork uow ,  IMapper mapper)
        {
            // this.dc = Dc;
            this.uow = uow;
            Mapper = mapper;
        }

        [HttpGet("cities")]
        [AllowAnonymous]
        public async Task<ActionResult> Getcities()
        {

            var cities = await uow.CityRepository.GetCitiesAsync();
            var citiesdto = Mapper.Map<IEnumerable<CityDto>>(cities);
            //var citiesdto = from c in cities
            //                select new CityDto()
            //                {
            //                    Id = c.Id,
            //                    Name = c.Name
            //                };
            return Ok(citiesdto);
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Unknown City ";
        }


        [HttpPost("post/{id}")]        
        public async Task<IActionResult> AddCity(CityDto cityDto)
        {
            //var city = new City
            //{
            //    Name = cityDto.Name,
            //    LastUpdatedBy = 1,
            //    LastUpdateOn = DateTime.Now
            //};
            var city = Mapper.Map<City>(cityDto);
           
            uow.CityRepository.AddCity(city);
           await  uow.SaveAsync();
           return StatusCode(201);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteCity(int id)
        {
            uow.CityRepository.DeleteCity(id);
            await  uow.SaveAsync();
            return Ok(id);
            //City city = new City();
            //city.Name = cityName;
            //var city = await dc.Cities.FindAsync(id);
            //if (city != null)
            //{
            //    dc.Cities.Remove(city);
            //    await dc.SaveChangesAsync();
            //    return Ok(id);
            //}
            //else
            //{
            //    return NotFound();
            //}


        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateCity(int id , CityDto citydto)
        {

            if (id != citydto.Id)
            {
                return BadRequest("Update Not Allowed");
            }

            var cityFromDb = await uow.CityRepository.FindCity(id);
            if (cityFromDb == null)
            {
                return BadRequest("Update Not Allowed");
            }
            cityFromDb.LastUpdateOn = DateTime.Now;
            cityFromDb.LastUpdatedBy= 2;
            Mapper.Map(citydto, cityFromDb);
            await  uow.SaveAsync();
            return StatusCode(200);
        }

        [HttpPatch("update/{id}")]
        public async Task<IActionResult> UpdateCityPatch(int id,JsonPatchDocument<City> citydtoPatch)
        {
            
            var cityFromDb = await uow.CityRepository.FindCity(id);
            
            if (cityFromDb == null)
            {
                return BadRequest("Update Not Allowed");
            }
            cityFromDb.LastUpdateOn = DateTime.Now;
            cityFromDb.LastUpdatedBy = 2;
            citydtoPatch.ApplyTo(cityFromDb, ModelState);   
            await uow.SaveAsync();
            return StatusCode(200);
        }

        [HttpPut("updateName/{id}")]//for partial update usin
        public async Task<IActionResult> UpdateCityName(int id, CityUpdateDto citydto)
        {
            var cityFromDb = await uow.CityRepository.FindCity(id);
            cityFromDb.LastUpdateOn = DateTime.Now;
            cityFromDb.LastUpdatedBy = 2;
            Mapper.Map(citydto, cityFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }
    }
}
