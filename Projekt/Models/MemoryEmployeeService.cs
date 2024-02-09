namespace Projekt.Models
{
    public class MemoryEmployeeService : IEmployeeService
    {
        private Dictionary<int, Employee> _employees =
            new Dictionary<int, Employee>()
            {
                {1, new Employee() {Id = 1, FirstName = "Jan", LastName = "Nowak", PESEL = "00010203456", Position = "President", Departament = "Operations", DateOfEmployment = new DateTime(2001, 9, 11), ReleaseDate = new DateTime(2012, 12, 21) } }
            };

        public void Add(Employee employee)
        {
            int id = _employees.Keys.Count != 0 ? _employees.Keys.Max() : 0;
            employee.Id = id + 1;
            _employees.Add(employee.Id, employee);
        }

        public void Delete(int id)
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
