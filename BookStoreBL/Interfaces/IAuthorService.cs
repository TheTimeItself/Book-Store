using BookStoreModels.Models;

namespace BookStoreBL.Interfaces
{
    public interface IAuthorService
    {
        public void Add(Author author);

        public void Delete(int id);

        public void Update(Author author);

        public Author? GetByID(int id);

        public List<Author> GetAll();
    }
}
