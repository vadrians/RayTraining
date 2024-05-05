using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Peliculas.API.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Peliculas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        // GET: api/<Peliculascontroller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Peliculascontroller>/5
        [HttpGet("{id}")]
        public  IActionResult  Get(int id)
        {
            return Ok(new Pelicula() {
            
            Nombre="Gladiador",Fecha=new DateTime(2004,4,22)});
            
        }

        // POST api/<Peliculascontroller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Peliculascontroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Peliculascontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
