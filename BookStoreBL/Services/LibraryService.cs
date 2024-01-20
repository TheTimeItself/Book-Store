using BookStoreBL.Interfaces;
using BookStoreModels.Requests;
using BookStoreModels.Responses;

namespace BookStoreBL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        public LibraryService(IAuthorService authorService, IBookService bookService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        public int CheckBookCount(int input)
        {
            var bookCount = _bookService.GetAll();

            return bookCount.Count + input;
        }

        public GetAllBooksByAuthorResponse GetGetAllBooksByAuthorAfterReleaseDate(GetAllBooksByAuthorRequest request)
        {
            var response = new GetAllBooksByAuthorResponse
            {
                Author = _authorService.GetByID(request.AuthorID),
                Books = _bookService.GetAllByAuthorAfterReleaseDate(request.AuthorID, request.DateAfter)
            };

            return response;
        }
    }
}
