using BookStoreDL.InMemoryDb;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreDL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            StaticData.Books.Add(book);
        }

        public void Delete(int id)
        {
            var book = StaticData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return;
            }
            StaticData.Books.Remove(book);
        }

        public List<Book> GetAll()
        {
            return StaticData.Books;
        }

        public Book? GetByID(int id)
        {
            return StaticData.Books.Find(x => x.Id == id);
        }

        public void Update(Book book)
        {
            var books = StaticData.Books;
        }
        public void UpdateBook(Book book)
        {
            var existingBook = StaticData.Books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook == null) return;
        }
    }
}
