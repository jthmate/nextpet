using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NextPetDomain.Models
{
    public class EmployeeModel : IEmployeeInterface
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50), ]
        [Column("first_name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("birth_date")]
        public DateTime BirthDate { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("country")]
        public string Country { get; set; }

        [ForeignKey("EmployeeId")]
        public ICollection<PetModel> Pets { get; set; }

    }
}
