namespace LibraryManagementSystem.Models
{
    public class Author
    {
        public int Id { get; set; } // Benzersiz kimlik
        public string FirstName { get; set; } // Yazarın adı
        public string LastName { get; set; } // Yazarın soyadı
        public DateTime DateOfBirth { get; set; } // Yazarın doğum tarihi
    }
}
