using Library.BLL.Model;
using Library.BLL.Services;
using Library.BLL.Services.Interfaces;
using Library.DAL;
using Library.DAL.Entityes;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.PL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        
        private readonly IBookService _services;

        public BookController(IBookService category)
        {
            
            _services = category;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<BookModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public BookModel Get(int id)
        {
            return _services.GetById(id);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] BookModel value)
        {
            _services.Create(value);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] BookModel value)
        {
            _services.Update(value);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
