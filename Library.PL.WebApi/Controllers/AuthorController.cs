using Library.BLL.Model;
using Library.BLL.Services;
using Library.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.PL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly IAuthorService _services;

        public AuthorController(IAuthorService category)
        {

            _services = category;
        }

        // GET: api/<AuthorController>
        [HttpGet]
        public IEnumerable<AuthorModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public AuthorModel Get(int id)
        {
            return _services.GetById(id);
        }

        // POST api/<AuthorController>
        [HttpPost]
        public void Post([FromBody] AuthorModel value)
        {
            _services.Create(value);
        }

        // PUT api/<AuthorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AuthorModel value)
        {
            _services.Update(value);
        }

        // DELETE api/<AuthorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
