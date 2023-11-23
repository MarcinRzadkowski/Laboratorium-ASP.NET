using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_4___App.Models
{
    public class Employee
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }        
        [RegularExpression("[0-9]{4}[0-3]{1}[0-9]{6}",ErrorMessage = "Nieprawidłowy format numeru PESEL" )]
        [Display(Name = "PESEL")]
        public string PESEL { get; set; }
        [Display(Name = "Stanowisko")]
        public string Position { get; set; }        
        [Display(Name = "Dział")]
        public Departament Departament { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data zatrudnienia")]
        public string DateOfEmployment { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data Zwolnienia")]
        public string? ReleaseDate { get; set; }
    }
}
