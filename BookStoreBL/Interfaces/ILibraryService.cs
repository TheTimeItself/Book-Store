using BookStoreModels.Requests;
using BookStoreModels.Responses;

namespace BookStoreBL.Interfaces
{
    public interface ILibraryService
    {
        public GetAllBooksByAuthorResponse GetGetAllBooksByAuthorAfterReleaseDate(GetAllBooksByAuthorRequest request);
    }
}
