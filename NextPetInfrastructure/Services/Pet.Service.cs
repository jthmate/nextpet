using NextPetDomain.Models;

namespace NextPetInfrastructure.Services
{
    public class PetService
    {
        public IPetInterface GetPet(int id)
        {
            return new PetRepository().GetOnePet(id);
        }

        public IPetInterface[] GetPetList()
        {
            return new PetRepository().GetPetList();
        }

        public IPetInterface PostPet(PetModel data)
        {
            return new PetRepository().PostPet(data);
        }

        public IPetInterface PutPet(int id, PetModel data)
        {
            return new PetRepository().PutPet(id, data);
        }

        public bool DeletePet(int id)
        {
            return new PetRepository().DeletePet(id);
        }
    }
}
