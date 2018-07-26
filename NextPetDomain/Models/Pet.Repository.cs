using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NextPetDomain.Models
{
    public class PetRepository : DbContext
    {
        public IPetInterface GetOnePet(int id)
        {
            using (var context = new NextPetDbContext())
            {
                return context.Pet.Find(id);
            }
        }

        public IPetInterface[] GetPetList()
        {
            using (var context = new NextPetDbContext())
            {
                return (from b in context.Pet select b).ToArray();
            }
        }

        public IPetInterface PostPet(PetModel pet)
        {
            // Insert pet
            using (var context = new NextPetDbContext())
            {
                context.Pet.Add(pet);
                context.SaveChanges();
            }

            return pet;
        }

        public IPetInterface PutPet(int id, PetModel petUpdated)
        {
            // Update pet
            using (var context = new NextPetDbContext())
            {
                var pet = context.Pet.Find(id);
                pet.Name = petUpdated.Name;
                pet.Type= petUpdated.Type;
                pet.BirthDate = petUpdated.BirthDate;
                pet.EmployeeId = petUpdated.EmployeeId;

                context.Entry(pet).State = EntityState.Modified;
                context.SaveChanges();

                return pet;
            }
        }

        public bool DeletePet(int id)
        {
            using (var context = new NextPetDbContext())
            {
                var pet = context.Pet.Find(id);
                context.Pet.Remove(pet);
                context.SaveChanges();

                return true;
            }
        }
    }
}
