using System;
using Microsoft.AspNetCore.Mvc;
using NextPetInfrastructure.Services;
using NextPetDomain.Models;

namespace NextPetAdapter.Controllers.Employee
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        // GET: api/employee
        // Get the list of employees.
        [HttpGet]
        public IEmployeeInterface[] Get()
        {
            return new EmployeeService().GetEmployeeList();
        }

        // GET api/employee/5
        // Get one specific employee by ID.
        [HttpGet("{id}")]
        public IEmployeeInterface Get(int id)
        {
            try {
                if (0 < id) {
                    return new EmployeeService().GetEmployee(id);
                }    
            } catch (Exception ex) {
                throw new Exception("Error!!!" + ex.Message);
            }           


            return null;
        }

        // GET api/employee/5/pet
        // Get pet list from specific employee ID.
        [HttpGet("{id}/pet")]
        public IPetInterface[] GetPet(int id)
        {
            try
            {
                if (0 < id)
                {
                    return new EmployeeService().GetEmployeePetList(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }


            return null;
        }

        // POST api/employee
        // Insert a new employee.
        [HttpPost]
        public IEmployeeInterface Post(string firstName, string lastName, string birthDate, string city, string country)
        {
            try {


                EmployeeModel newEmployee = CreateNewEmployee(firstName, lastName, birthDate, city, country);

                return new EmployeeService().PostEmployee(newEmployee);    

            } catch (Exception ex) {
                throw new Exception("Error: " + ex.Message);
            }
        }

        // PUT api/employee/
        // Update an employee by ID.
        [HttpPut("{id}")]
        public IEmployeeInterface Put(int id, string firstName, string lastName, string birthDate, string city, string country)
        {
            if (id <= 0) {
                throw new Exception("Error: The field ID is mandatory to update an employee.");
            }

            try
            {
                EmployeeModel newEmployee = CreateNewEmployee(firstName, lastName, birthDate, city, country);

                return new EmployeeService().PutEmployee(id, newEmployee);

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        // DELETE api/employee/5
        // Delete an employee by ID.
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Error: The field ID is mandatory to delete an employee.");
            }

            return new EmployeeService().DeleteEmployee(id);
        }

        private EmployeeModel CreateNewEmployee(string firstName, string lastName, string birthDate, string city, string country) {

            EmployeeModel newEmployee = new EmployeeModel();

            if (null != firstName)
            {
                newEmployee.FirstName = firstName;
            }
            if (null != lastName)
            {
                newEmployee.LastName = lastName;
            }
            if (null != birthDate)
            {
                newEmployee.BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", null);
            }
            if (null != city)
            {
                newEmployee.City = city;
            }
            if (null != country)
            {
                newEmployee.Country = country;
            }

            return newEmployee;

        }
    }
}
