using System;
namespace NextPetAdapter.Interfaces
{
    public interface IFormEmployeeInterface
    {
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime birthDate { get; set; }
        string city { get; set; }
        string country { get; set; }
    }

    public interface IEmployeeInterface
    {
        int ID { get; }
        string firstName { get; }
        string lastName { get; }
        DateTime birthDate { get; }
        string city { get; }
        string country { get; }
    }
}
