using BookStoreDL.InMemoryDb;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void AddBook(Book book)
        {
            StaticData.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
           var book = StaticData.Books.FirstOrDefault(b => b.Id == id);

            if (book == null) return;

            StaticData.Books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return StaticData.Books;
        }

        public Book? GetBook(int id)
        {
            return StaticData.Books.FirstOrDefault(b => b.Id == id);
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
