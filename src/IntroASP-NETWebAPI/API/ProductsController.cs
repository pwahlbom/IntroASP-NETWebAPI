using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroASP_NETWebAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IntroASP_NETWebAPI.API
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        static List<Product> _products = new List<Product>
            {
                new Product {Id=1, Name="Milk", Price=2.33m},
                new Product {Id=2, Name="Cheese", Price=5.44m},
                new Product {Id=3, Name="Apples", Price=2.50m}
            };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _products.Add(product);
            return Created("/products/" + product.Id, product);
        }

    }
    //[Route("api/[controller]")]
    //public class ProductsController : Controller
    //{
    //    // GET: api/values
    //    [HttpGet]
    //    public IEnumerable<string> Get()
    //    {
    //        return new string[] { "value1", "value2" };
    //    }

    //    // GET api/values/5
    //    [HttpGet("{id}")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST api/values
    //    [HttpPost]
    //    public void Post([FromBody]string value)
    //    {
    //    }

    //    // PUT api/values/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody]string value)
    //    {
    //    }

    //    // DELETE api/values/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //    }
    //}
}
