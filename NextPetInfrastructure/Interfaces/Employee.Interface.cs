using System;
using NextPetInfrastructure.Interfaces;
namespace NextPetInfrastructure.Interfaces
{
    public interface IServiceEmployeeInterface
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        DateTime BirthDate { get; set; }
        string City { get; set;}
        string Country { get; set; }
        // IServicePetInterface[] Pets { get; set; }
    }
}
