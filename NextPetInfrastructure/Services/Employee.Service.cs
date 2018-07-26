using NextPetDomain.Models;

namespace NextPetInfrastructure.Services
{
    public class EmployeeService
    {
        public IEmployeeInterface GetEmployee(int id)
        {
            return new EmployeeRepository().GetOneEmployee(id);
        }

        public IEmployeeInterface[] GetEmployeeList()
        {
            return new EmployeeRepository().GetEmployeeList();
        }

        public IPetInterface[] GetEmployeePetList(int id)
        {
            return new EmployeeRepository().GetEmployeePetList(id);
        }

        public IEmployeeInterface PostEmployee(EmployeeModel data)
        {
            return new EmployeeRepository().PostEmployee(data);
        }

        public IEmployeeInterface PutEmployee(int id, EmployeeModel data)
        {
            return new EmployeeRepository().PutEmployee(id, data);
        }

        public bool DeleteEmployee(int id)
        {
            return new EmployeeRepository().DeleteEmployee(id);
        }
    }
}
