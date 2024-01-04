using BookStoreModels.Models;

namespace BookStoreModels.Responses
{
    public class GetAllBooksByAuthorResponse
    {
        public Author Author { get; set; }

        public List<Book> Books { get; set; }
    }
}
