using DataProjekt;
namespace Projekt.Models
{
    public class EFEmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EFEmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(EmployeeMapper.toEntity(employee));
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Employees.Find(id);
            if (entity != null)
            {
                _context.Employees.Remove(entity);
            }
            _context.SaveChanges();
        }

        public List<Employee> FindAll()
        {
            return _context.Employees.Select(e => EmployeeMapper.fromEntity(e)).ToList();
        }

        public Employee? FindById(int id)
        {
            var entity = _context.Employees.Find(id);
            if (entity is not null)
            {
                return EmployeeMapper.fromEntity(entity);
            }
            else
            {
                return null;
            }
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(EmployeeMapper.toEntity(employee));
            _context.SaveChanges();
        }
    }
}
