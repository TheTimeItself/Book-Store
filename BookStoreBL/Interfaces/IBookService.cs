using BookStoreModels.Models;

namespace BookStoreBL.Interfaces
{
    public interface IBookServiceg
    {
        public void AddBook(Book book);

        public void DeleteBook(int id);

        public void UpdateBook(Book book);

        public Book? GetBook(int id);

        public List<Book> GetAllBooks();
    }
}
