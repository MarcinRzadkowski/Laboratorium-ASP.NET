namespace Laboratorium_4___App.Models
{
    public class EmployeeService : IEmployeeService
    {
        private Dictionary<int, Employee> _employees;
        private int _id = 0;

        public void Add(Employee employee)
        {
            employee.Id = _id++;
            _employees[employee.Id] = employee;
        }

        public void DeleteById(int id)
        {
            _employees.Remove(id);
        }

        public List<Employee> FindAll()
        {
            return _employees.Values.ToList();
        }

        public Employee? FindById(int id)
        {
            return _employees[id];
        }

        public void Update(Employee employee)
        {
            _employees[employee.Id] = employee;
        }
    }
}
