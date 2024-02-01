using Data_App;
using Data_App.Entities;
using Laboratorium_4___App.Mappers;

namespace Laboratorium_4___App.Models
{
    public class EFEmployeeService : IEmployeeService
    {
        private AppDbContext _context;

        public EFEmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Employee employee)
        {
            var e = _context.Employees.Add(EmployeeMapper.ToEntity(employee));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void DeleteById(int id)
        {
            EmployeeEntity? find = _context.Employees.Find(id);
            if(find != null)
            {
                _context.Employees.Remove(find);
            }
        }

        public List<Employee> FindAll()
        {
            return _context.Employees.Select(e => EmployeeMapper.FromEntity(e)).ToList();
        }

        public Employee? FindById(int id)
        {
            return EmployeeMapper.FromEntity(_context.Employees.Find(id));
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(EmployeeMapper.ToEntity(employee));
        }
    }
}
