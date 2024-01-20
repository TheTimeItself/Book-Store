using BookStoreDL.InMemoryDb;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreDL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            InMemoryDb.InMemoryDb.Books.Add(book);
        }

        public void Remove(int id)
        {
            var book = GetByID(id);
            if (book == null)
            {
                return;
            }
            InMemoryDb.InMemoryDb.Books.Remove(book);
        }

        public List<Book> GetAll()
        {
            return InMemoryDb.InMemoryDb.Books;
        }

        public Book? GetByID(int id)
        {
            return InMemoryDb.InMemoryDb.Books.First(a => a.Id == id);
        }
        public List<Book> GetAllByAuthor(int authorId)
        {
        return InMemoryDb.InMemoryDb.Books.Where(b => b.AuthorId == authorId).ToList();
        }
    }
}
