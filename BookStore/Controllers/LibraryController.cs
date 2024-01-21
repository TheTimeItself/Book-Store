using BookStoreBL.Interfaces;
using BookStoreModels.Requests;
using BookStoreModels.Responses;
using Microsoft.AspNetCore.Mvc;
using BookStore.Validators;
using Microsoft.AspNetCore.Http;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetAllBooksByAuthorAndDate")]
        public GetAllBooksByAuthorResponse GetAllBooksByAuthorAndDate([FromBody] GetAllBooksByAuthorRequest request)
        {
            return _libraryService.GetGetAllBooksByAuthorAfterReleaseDate(request);
        }

        //[HttpPost("SomeEndpoint")]
        //public string GetSomeData([FromBody] SomeRequest request)
        //{
        //return "Ok";
        //}
    }
}
