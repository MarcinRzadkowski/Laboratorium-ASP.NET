using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię")]
        [StringLength(50, ErrorMessage = "Imię jest za długie")]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        [Display(Name = "e-mail")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
        [Display(Name = "Nr telefonu")]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }

    }
}
