namespace BookStoreModels.Models
{
    public record Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
    }
}
