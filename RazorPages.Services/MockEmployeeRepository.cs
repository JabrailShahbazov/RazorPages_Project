//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;
//using RazorPages.Models;

//namespace RazorPages.Services
//{
//    public class MockEmployeeRepository : IEmployeeRepository
//    {
//        private readonly List<Employee> _employeeList;
//        public MockEmployeeRepository()
//        {
//            _employeeList = new List<Employee>
//            {
//                new Employee()
//                {
//                    Id = 1,Name = "Mary",Department = Dept.HR, Email = "mary@mail.com",PhotoPath ="P1.jpg"
//                }, new Employee()
//                {
//                    Id = 2,Name = "John",Department = Dept.IT, Email = "John@mail.com",PhotoPath ="P2.jpg"
//                }, new Employee()
//                {
//                    Id = 3,Name = "Sara",Department = Dept.None, Email = "sara@mail.com",PhotoPath ="P3.jpg"
//                }, new Employee()
//                {
//                    Id = 4,Name = "David",Department = Dept.Payroll, Email = "david@mail.com"
//                },
//            };
//        }
//        public IEnumerable<Employee> GetAllEmployees()
//        {
//            return _employeeList;
//        }

//        public IEnumerable<Employee> Search(string searchTerm)
//        {
//            if (string.IsNullOrEmpty(searchTerm))
//            {
//                return _employeeList;
//            }

//            return _employeeList.Where(e => e.Name.Contains(searchTerm) ||
//                                            e.Email.Contains(searchTerm));
//        }

//        public Employee GetEmployee(int id)
//        {
//            return _employeeList.FirstOrDefault(e => e.Id == id);
//        }

//        public Employee Update(Employee updatedEmployee)
//        {
//          Employee employee=  _employeeList.FirstOrDefault(e => e.Id == updatedEmployee.Id);
//          if (employee != null)
//          {
//              employee.Name = updatedEmployee.Name;
//              employee.Email = updatedEmployee.Email;
//              employee.Department = updatedEmployee.Department;
//              employee.PhotoPath = updatedEmployee.PhotoPath;
//          }

//          return employee;
//        }

      
//        public Employee Add(Employee newEmployee)
//        {
//            newEmployee.Id = _employeeList.Max(e => e.Id) + 1;
//            _employeeList.Add(newEmployee);
//            return newEmployee;
//        }

//        public Employee DeleteToEmployee(int id)
//        {
//            Employee deleteEmployee = _employeeList.FirstOrDefault(x => x.Id == id);
//            if (deleteEmployee != null)
//            {
//                _employeeList.Remove(deleteEmployee);
//            }

//            return deleteEmployee;
//        }

     
//    }
//}
