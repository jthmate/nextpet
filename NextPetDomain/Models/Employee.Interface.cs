using System;
using System.Collections.Generic;
namespace NextPetDomain.Models
{
    public interface IEmployeeInterface
    {
        int ID { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        string City { get; set; }
        string Country { get; set; }
    }
}
