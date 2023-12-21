using BookStoreDL.InMemoryDb;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreDL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            StaticData.Books.Add(book);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
           var book = StaticData.Books.FirstOrDefault(b => b.Id == id);

            if (book == null) return;

            StaticData.Books.Add(book);
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return StaticData.Books;
        }

        public Book? GetBook(int id)
        {
            return StaticData.Books.FirstOrDefault(b => b.Id == id);
        }

        public Book? GetByID()
        {
            throw new NotImplementedException();
        }

        public Book? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            var existingbook = StaticData.Books.FirstOrDefault(b => b.Id == book.Id);

            if (existingbook == null) return;

            existingbook = new Book()
            {
                Title = book.Title,
            };
        }
    }
}
