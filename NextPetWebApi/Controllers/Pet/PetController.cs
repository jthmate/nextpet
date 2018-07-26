using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NextPetInfrastructure.Services;
using NextPetDomain.Models;

namespace NextPetAdapter.Controllers.Pet
{
    [Route("api/[controller]")]
    public class PetController : Controller
    {
        // GET: api/pet
        [HttpGet]
        public IPetInterface[] Get()
        {
            return new PetService().GetPetList();
        }

        // GET api/pet/5
        [HttpGet("{id}")]
        public IPetInterface Get(int id)
        {
            try
            {
                if (0 < id)
                {
                    return new PetService().GetPet(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error!!!" + ex.Message);
            }


            return null;
        }

        // POST api/pet
        [HttpPost]
        public IPetInterface Post(string name, string type, string birthDate, int employeeId)
        {
            try
            {
                PetModel newPet = CreateNewPet(name, type, birthDate, employeeId);
               
                return new PetService().PostPet(newPet);

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        // PUT api/pet/
        [HttpPut("{id}")]
        public IPetInterface Put(int id, string name, string type, string birthDate, int employeeId)
        {
            if (id <= 0)
            {
                throw new Exception("Error: The field ID is mandatory to update an pet.");
            }

            try
            {
                PetModel newPet = CreateNewPet(name, type, birthDate, employeeId);

                return new PetService().PutPet(id, newPet);

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        // DELETE api/pet/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Error: The field ID is mandatory to delete an pet.");
            }

            return new PetService().DeletePet(id);
        }

        private PetModel CreateNewPet(string name, string type, string birthDate, int employeeId) {
            
            PetModel newPet = new PetModel();

            if (null != name)
            {
                newPet.Name = name;
            }
            if (null != type)
            {
                newPet.Type = type;
            }
            if (null != birthDate)
            {
                newPet.BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", null);
            }
            if (0 < employeeId)
            {
                newPet.EmployeeId = employeeId;
            }

            return newPet;
        }
    }
}
