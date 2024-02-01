namespace Laboratorium_4___App.Models
{
    public class MemoryEmployeeService : IEmployeeService
    {
        private Dictionary<int, Employee> _employees =
            new Dictionary<int, Employee>();
            
        private int _id = 1;

        public int Add(Employee employee)
        {
            employee.Id = _id++;
            _employees[employee.Id] = employee;
            return employee.Id;
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
