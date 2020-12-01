using System;
using System.Collections.Generic;
using RazorPages.Models;

namespace RazorPages.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        IEnumerable<Employee> Search(string searchTerm);
        Employee GetEmployee(int id);
        Employee Update(Employee updatedEmployee);
        Employee Add(Employee newEmployee);
        Employee DeleteToEmployee(int id);

    }
}
