using BookStoreModels.Models;

namespace BookStoreDL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        void Add(Author author);
        void Delete(int id);
        void Update(Author author);
        Author? GetByID(int id);
    }
}
