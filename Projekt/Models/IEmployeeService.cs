namespace Projekt.Models
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Delete(int id);
        void Update(Employee employee);
        List<Employee> FindAll();
        Employee? FindById(int id);

    }
}
