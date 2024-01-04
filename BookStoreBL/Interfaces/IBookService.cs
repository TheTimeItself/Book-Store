using BookStoreModels.Models;

namespace BookStoreBL.Interfaces
{
    public interface IBookService
    {
        public void Add(Book book);

        public void Delete(int id);

        public void Update(Book book);

        public Book? GetByID(int id);

        public List<Book> GetAll();

        public List<Book> GetAllByAuthorAfterReleaseDate(int authoreId, DateTime afterDate);
    }
}
