using System;
namespace NextPetAdapter.Interfaces
{
    public interface IFormPetInterface
    {
        string name { get; set; }
        string type { get; set; }
        DateTime birthDate { get; set; }
        int employeeId { get; set; }
    }
}
