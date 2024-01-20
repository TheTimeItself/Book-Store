using BookStoreModels.Models;

namespace BookStoreDL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        void Add(Author author);
        void Remove(int id);
        Author? GetByID(int id);
    }
}
