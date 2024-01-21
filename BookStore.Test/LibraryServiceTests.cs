using BookStoreBL.Services;
using BookStoreDL.Interfaces;
using BookStoreDL.Repositories;
using BookStoreModels.Models;
using BookStoreModels.Requests;
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

        [Fact]
        public void CheckBookCount_NegativeInput()
        {
            //setup
            var input = -10;
            var expectedCount = 0;

            var mockedBookRepository = new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.GetAll()).Returns(Books);

            //inject
            var bookService = new BookService(mockedBookRepository.Object);
            var authorService = new AuthorService(new AuthorRepository());
            var service = new LibraryService(authorService, bookService);

            //act
            var result = service.CheckBookCount(input);

            //Assert
            Assert.Equal((int)expectedCount, result);
        }

        [Fact]
        public void GetAllBooksByAuthorAfterReleaseDate_OK()
        {
            //setup
            var request = new GetAllBooksByAuthorRequest
            {
                AuthorID = 1,
                DateAfter = new DateTime(1999, 2, 3)
            };
            var expectedCount = 2;

            var mockedBookRepository = new Mock<IBookRepository>();
            var mockedAuthorRepository = new Mock<IAuthorRepository>();

            mockedBookRepository.Setup(x => x.GetAllByAuthor(request.AuthorID)).Returns(Books.Where(b => b.AuthorId == request.AuthorID).ToList());
            mockedAuthorRepository.Setup(x => x.GetByID(request.AuthorID)).Returns(Authors!.FirstOrDefault(a => a.Id == request.AuthorID)!);

            //inject
            var bookService = new BookService(mockedBookRepository.Object);
            var authorService = new AuthorService(new AuthorRepository());
            var service = new LibraryService(authorService, bookService);

            //act
            var result = service.GetGetAllBooksByAuthorAfterReleaseDate(request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result!.Books.Count);
            Assert.Equal(request.AuthorID, result.Author.Id);
        }
    }
}