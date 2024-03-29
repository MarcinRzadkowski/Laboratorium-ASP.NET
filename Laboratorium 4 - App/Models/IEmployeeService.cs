﻿namespace Laboratorium_4___App.Models
{
    public interface IEmployeeService
    {
        int Add(Employee employee);
        void DeleteById(int id);
        void Update(Employee employee);
        List<Employee> FindAll();
        Employee? FindById(int id);
    }
}
