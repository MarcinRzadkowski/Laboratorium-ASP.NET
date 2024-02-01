using Data_App.Entities;
using Laboratorium_4___App.Models;

namespace Laboratorium_4___App.Mappers
{
    public class EmployeeMapper
    {
        public static Employee FromEntity(EmployeeEntity entity)
        {
            return new Employee()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                PESEL = entity.PESEL,
                Position = entity.Position,
                Departament = entity.Departament,
                DateOfEmployment = entity.DateOfEmployment,
                ReleaseDate = entity.ReleaseDate
            };
        }

        public static EmployeeEntity ToEntity(Employee model) 
        {
            return new EmployeeEntity()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PESEL = model.PESEL,
                Position = model.Position,
                Departament = model.Departament,
                DateOfEmployment = model.DateOfEmployment,
                ReleaseDate = model.ReleaseDate
            };
        }
    }
}
