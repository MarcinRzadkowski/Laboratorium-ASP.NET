using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_App.Entities
{
    [Table("employees")]
    public class EmployeeEntity
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [StringLength(11)]
        [Required]
        public string PESEL { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        public Departament Departament { get; set; }
        [Column("time in the company")]
        [Required]
        [DataType(DataType.Date)]
        public string DateOfEmployment { get; set; }
        [DataType(DataType.Date)]
        public string? ReleaseDate { get; set; }
    }
}
