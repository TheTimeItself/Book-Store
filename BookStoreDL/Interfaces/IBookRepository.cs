using BookStoreModels.Models;

namespace BookStoreDL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        void Add(Book book);
        void Remove(int id);
        Book? GetByID(int id);
        List<Book> GetAllByAuthor(int authorId);

    }
}
