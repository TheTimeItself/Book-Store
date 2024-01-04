using BookStoreModels.Models;

namespace BookStoreDL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        void Add(Book book);
        void Delete(int id);
        void Update(Book book);
        Book? GetByID(int id);
    }
}
