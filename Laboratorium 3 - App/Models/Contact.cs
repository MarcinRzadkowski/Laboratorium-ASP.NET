using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię")]
        [StringLength(50, ErrorMessage = "Imię jest za długie")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
        public string Phone { get; set; }
        [DataType(DataType.Date]
        public string? Birth { get; set; }
    }
}
