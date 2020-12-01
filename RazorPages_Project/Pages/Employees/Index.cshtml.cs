using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPages_Project.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> Employees { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } 

        //GET: Employees/Index
        public void OnGet()
        {
            Employees = _employeeRepository.Search(SearchTerm);
        }
    }
}
