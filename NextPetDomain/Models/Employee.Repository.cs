using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NextPetDomain.Models
{
    public class EmployeeRepository: DbContext
    {
        public IEmployeeInterface GetOneEmployee(int id)
        {
            using (var context = new NextPetDbContext())
            {
                return context.Employee.Find(id);
            }
        }

        public IEmployeeInterface[] GetEmployeeList()
        {
            using (var context = new NextPetDbContext())
            {
                return (from b in context.Employee select b).ToArray();
            }
        }

        public IPetInterface[] GetEmployeePetList(int id)
        {
            using (var context = new NextPetDbContext())
            {
                return (from b in context.Pet select b).Where(pet => pet.EmployeeId == id).ToArray();
            }
        }

        public IEmployeeInterface PostEmployee(EmployeeModel employee)
        {
            // Insert employee
            using (var context = new NextPetDbContext()){
                context.Employee.Add(employee);
                context.SaveChanges();
            }

            return employee;
        }

        public IEmployeeInterface PutEmployee(int id, EmployeeModel employeeUpdated)
        {
            // Update employee
            using (var context = new NextPetDbContext())
            {
                var employee = context.Employee.Find(id);
                employee.FirstName = employeeUpdated.FirstName;
                employee.LastName = employeeUpdated.LastName;
                employee.BirthDate = employeeUpdated.BirthDate;
                employee.City = employeeUpdated.City;
                employee.Country = employeeUpdated.Country;

                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();

                return employee;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (var context = new NextPetDbContext())
            {
                var employee = context.Employee.Find(id);
                context.Employee.Remove(employee);
                context.SaveChanges();

                return true;
            }
        }
    }
}
