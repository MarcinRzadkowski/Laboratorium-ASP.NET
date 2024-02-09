using DataProjekt.Entities;
namespace Projekt.Models
{
    public class EmployeeMapper
    {
        public static EmployeeEntity toEntity(Employee employee)
        {
            return new EmployeeEntity()
            {
                EmployeeId = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PESEL = employee.PESEL,
                Departament = employee.Departament,
                Position = employee.Position,
                DateOfEmployment = employee.DateOfEmployment,
                ReleaseDate = employee.ReleaseDate
            };
        }

        public static Employee fromEntity(EmployeeEntity entity)
        {
            return new Employee()
            {
                Id = entity.EmployeeId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                PESEL = entity.PESEL,
                Departament = entity.Departament,
                Position = entity.Position,
                DateOfEmployment = entity.DateOfEmployment,
                ReleaseDate = entity.ReleaseDate

            };
        }
    }
}
