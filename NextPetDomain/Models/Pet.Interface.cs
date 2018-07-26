using System;
namespace NextPetDomain.Models
{
    public interface IPetInterface
    {
        int ID { get; }
        string Name { get; set; }
        string Type { get; set; }
        DateTime BirthDate { get; set; }
        int EmployeeId { get; set; }
    }
}
