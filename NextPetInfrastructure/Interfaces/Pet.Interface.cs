using System;
namespace NextPetAdapter.Interfaces
{
    public interface IServicePetInterface
    {
        string name { get; set; }
        string type { get; set; }
        DateTime birthDate { get; set; }
    }
}
