using BookStoreModels.Models;

namespace BookStoreDL.InMemoryDb
{
    public static class StaticData
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title =  "Book 1"
            },

            new Book()
            {
                Id = 2,
                Title =  "Book 2"
            },

            new Book()
            {
                Id = 3,
                Title =  "Book 3"
            }
        };
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name =  "Arnold",
                BirthDay = new DateTime(2000, 11, 26),
            },

            new Author()
            {
                Id = 2,
                Name =  "Boqn",
                BirthDay = new DateTime(1997, 08, 18),
            },

            new Author()
            {
                Id = 3,
                Name =  "Tomas",
                BirthDay = new DateTime(2006, 04, 11),
            }
        };
    }
}
