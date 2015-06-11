﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using VideoApp.Domain.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoApp.Rest.API.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new List<Movie> { new Movie {MovieId =1, Title="Other Peoples Money" }, new Movie { MovieId = 2, Title = "House of cards" } };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

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
