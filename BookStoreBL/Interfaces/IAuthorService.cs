using BookStoreModels.Models;

namespace BookStoreBL.Interfaces
{
    public interface IAuthorService
    {
        public void Add(Author author);

        public void Remove(int id);

        public Author? GetByID(int id);

        public List<Author> GetAll();
    }
}
