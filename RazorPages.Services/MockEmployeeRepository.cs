using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorPages.Models;

namespace RazorPages.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee()
                {
                    Id = 1,Name = "Mary",Department = Dept.HR, Email = "mary@mail.com",PhotoPath ="P1.jpg"
                }, new Employee()
                {
                    Id = 2,Name = "John",Department = Dept.IT, Email = "John@mail.com",PhotoPath ="P2.jpg"
                }, new Employee()
                {
                    Id = 3,Name = "Sara",Department = Dept.None, Email = "sara@mail.com",PhotoPath ="P3.jpg"
                }, new Employee()
                {
                    Id = 4,Name = "David",Department = Dept.Payroll, Email = "david@mail.com"
                },
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
