using BookStoreDL.InMemoryDb;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreDL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
            InMemoryDb.InMemoryDb.Authors.Add(author);
        }
        public void Remove(int id)
        {
            var author = GetByID(id);
            if (author == null)
            {
                return;
            }
            InMemoryDb.InMemoryDb.Authors.Remove(author);
        }
        public List<Author> GetAll()
        {
            return InMemoryDb.InMemoryDb.Authors;
        }
        public Author? GetByID(int id)
        {
            return InMemoryDb.InMemoryDb.Authors.First(a => a.Id == id);
        }
    }
}
