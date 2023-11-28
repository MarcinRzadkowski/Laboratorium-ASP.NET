using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entites
{
    public class ContactEntity
    {
        [Key]
        public int ContactId { get; set; }

        [Column("contact_name")]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birth { get; set; }
    }
}
