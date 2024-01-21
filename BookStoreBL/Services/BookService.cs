using BookStoreBL.Interfaces;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreBL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Remove(int id)
        {
            _bookRepository.Remove(id);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book? GetByID(int id)
        {
            return _bookRepository.GetByID(id);
        }

        public List<Book> GetAllByAuthorAfterReleaseDate(int authorId, DateTime afterDate)
        {
            var result = _bookRepository.GetAllByAuthor(authorId);

            return result
                .Where(b => b.AuthorId == authorId).ToList();
        }
    }
}
