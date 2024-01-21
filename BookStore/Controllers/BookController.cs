using BookStoreBL.Interfaces;
using BookStoreModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookRepository)
        {
            _bookService = bookRepository;
        }

        [HttpGet("GetByID")]
        public Book? GetByID(int id)
        {
            if (id < 0) return null;

            return _bookService.GetByID(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Book book)
        {
            _bookService.Add(book);
        }
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _bookService.Remove(id);
        }
        [HttpGet("GetAll")]
        public void GetAll(int id)
        {
            _bookService.GetAll();
        }
    }
}