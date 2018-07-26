using System;
namespace NextPetDomain.Models
{
    public interface IFormEmployeeInterface
    {
         string FirstName { get; set; }
         string LastName { get; set; }
         DateTime BirthDate { get; set; }
         string City { get; set; }
         string Country { get; set; }
    }
}
