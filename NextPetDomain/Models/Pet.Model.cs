using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NextPetDomain.Models
{
    public class PetModel: IPetInterface
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("type")]
        public string Type { get; set; }
        [Column("birth_date")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Column("employee_id")]
        public int EmployeeId { get; set; }
    }
}
