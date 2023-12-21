using BookStoreModels.Models;

namespace BookStoreDL.Interfaces
{
    public interface IBookRepository
    {
        public void AddBook(Book book);

        public void DeleteBook(int id);

        public void UpdateBook(Book book);

        public Book? GetBook(int id);

        public List<Book> GetAllBooks();
        List<Book> GetAll();
        Book? GetByID();
        void Add(Book book);
        void Delete(int id);
        void Update(Book book);
        Book? GetByID(int id);
    }
}
