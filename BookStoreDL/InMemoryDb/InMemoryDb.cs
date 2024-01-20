using BookStoreModels.Models;

namespace BookStoreDL.InMemoryDb
{
    public static class InMemoryDb
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title =  "Book 1",
                AuthorId = 1,
                ReleaseDate = new DateTime(2005, 05, 07),
            },

            new Book()
            {
                Id = 2,
                Title =  "Book 2",
                AuthorId = 2,
                ReleaseDate = new DateTime(2008, 08, 14),
            },

            new Book()
            {
                Id = 3,
                Title =  "Book 3",
                AuthorId = 3,
                ReleaseDate = new DateTime(2001, 05, 29),
            },
            new Book()
            {
                Id = 4,
                Title =  "Book 4",
                AuthorId = 1,
                ReleaseDate = new DateTime(2004, 05, 08),
            }
        };
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name =  "Arnold",
                BirthDay = new DateTime(1988, 11, 26),
            },

            new Author()
            {
                Id = 2,
                Name =  "Boqn",
                BirthDay = new DateTime(1981, 08, 18),
            },

            new Author()
            {
                Id = 3,
                Name =  "Tomas",
                BirthDay = new DateTime(1987, 04, 11),
            }
        };
    }
}
