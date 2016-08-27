using IntroASP_NETWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IntroASP_NETWebAPI.API
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        static List<Movie> _movies = new List<Movie>
            {
                new Movie {Id=1, Name="Milk", Director="Bob", RunTime=90},
                new Movie {Id=2, Name="Cheese", Director="Sue", RunTime=120},
                new Movie {Id=3, Name="Apples", Director="John", RunTime=105}
            };

        // GET: api/values
        // -----------------------------------------------------------------
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movies;
        }
        // -----------------------------------------------------------------
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        // -----------------------------------------------------------------
        [HttpPost]
        public void Post([FromBody]Movie movie)
        {
            _movies.Add(movie);
        }
        // -----------------------------------------------------------------
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}