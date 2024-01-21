using BookStoreBL.Interfaces;
using BookStoreBL.Services;
using BookStoreModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorRepository)
        {
            _authorService = authorRepository;
        }

        [HttpGet("GetByID")]
        public Author? GetByID(int id)
        {
            if (id < 0) return null;

            return _authorService.GetByID(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Author author)
        {
            _authorService.Add(author);
        }
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _authorService.Remove(id);
        }
        [HttpGet("GetAll")]
        public void GetAll(int id)
        {
            _authorService.GetAll();
        }
    }
}