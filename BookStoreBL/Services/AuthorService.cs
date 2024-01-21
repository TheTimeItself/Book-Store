using BookStoreBL.Interfaces;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreBL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void Add(Author author)
        {
            _authorRepository.Add(author);
        }

        public void Remove(int id)
        {
            _authorRepository.Remove(id);
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author? GetByID(int id)
        {
            return _authorRepository.GetByID(id);
        }
    }
}
