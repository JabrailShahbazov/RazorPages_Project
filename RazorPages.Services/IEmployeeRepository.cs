using System;
using System.Collections.Generic;
using RazorPages.Models;

namespace RazorPages.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
