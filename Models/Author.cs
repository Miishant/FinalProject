namespace LibraryManagementSystem.Models
{
    public class Author
    {
        public int AuthorId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Nationality { get; set; }

        public ICollection<Book> Books { get; set; } // Navigation Property
    }
}
