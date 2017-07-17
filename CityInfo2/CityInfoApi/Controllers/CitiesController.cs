using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoApi.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
            //return new JsonResult(new List<object>()
            //{
            //    new{id =1, Name="New York" },
            //    new {id= 2, Name ="Lansdale" }
            //});
        }
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var CitytoReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(CitytoReturn== null)
            {
                return NotFound("City Not Found");
            }
            return Ok(CitytoReturn);
        }

    }
}