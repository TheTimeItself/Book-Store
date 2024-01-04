namespace BookStoreModels.Requests
{
    public class GetAllBooksByAuthorRequest
    {
        public int AuthorID { get; set; }

        public DateTime DateAfter { get; set; }
    }
}
