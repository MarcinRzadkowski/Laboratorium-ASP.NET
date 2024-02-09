using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProjekt.Entities
{
    [Table("employees")]
    public class EmployeeEntity
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string PESEL { get; set; }
        
        public string Position { get; set; }
        
        public string Departament { get; set; }
        
        public DateTime DateOfEmployment { get; set; }
        
        public DateTime? ReleaseDate { get; set; }
    }
}
