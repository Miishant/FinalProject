namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookId { get; set; } // Primary Key
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; } // Foreign Key

        public Author Author { get; set; } // Navigation Property
    }
}
