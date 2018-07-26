using System;
namespace NextPetAdapter.Interfaces
{
    public interface EmployeeInterface
    {
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime birthDate { get; set; }
        string city { get; set; }
        string country { get; set; }
    }
}
