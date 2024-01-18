using BookStoreBL.Services;
using BookStoreDL.Interfaces;
using BookStoreDL.Repositories;
using BookStoreModels.Models;
using Moq;

namespace BookStore.Test
{
    public class LibraryServiceTests
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

        [Fact]
        public void CheckBookCount_OK()
        {
            //setup
            var input = 10;
            var expectedCount = 14;

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAll()).Returns(Books);

            //inject
            var bookService = new BookService(mockedBookRepository.Object);
            var authorService = new AuthorService(new AuthorRepository());
            var service = new LibraryService(authorService, bookService);

            //act
            var result = service.CheckBookCount(input);

            //Assert
            Assert.Equal(expectedCount, result);

        }

        public void Check
    }
}