namespace Laboratorium_4___App.Models
{
    public class MemoryEmployeeService : IEmployeeService
    {
        private Dictionary<int, Employee> _employees = 
            new Dictionary<int, Employee>()
            {
                {1, new Employee() { Id =1, FirstName = "Jan", LastName = "Kowalski", PESEL = "68121213214", Position = "junior", Departament = Departament.Sales, DateOfEmployment = "19.11.2001"} },
            };
        private int _id = 1;

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
