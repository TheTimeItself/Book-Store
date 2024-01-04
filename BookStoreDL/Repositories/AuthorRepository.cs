using BookStoreDL.InMemoryDb;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreDL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
            StaticData.Authors.Add(author);
        }
        public void Delete(int id)
        {
            var author = StaticData.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return;
            }
            StaticData.Authors.Remove(author);
        }
        public List<Author> GetAll()
        {
            return StaticData.Authors;
        }
        public Author? GetByID(int id)
        {
            return StaticData.Authors.Find(x => x.Id == id);
        }

        public void Update(Author author)
        {
            var authors = StaticData.Authors;
        }
        public void UpdateAuthor(Author author)
        {
            var existingAuthor = StaticData.Authors.FirstOrDefault(b => b.Id == author.Id);
            if (existingAuthor == null) return;
        }
    }
}
