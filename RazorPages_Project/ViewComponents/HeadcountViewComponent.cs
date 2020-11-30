using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorPages.Services;

namespace RazorPages_Project.ViewComponents
{
    public class HeadcountViewComponent :ViewComponent
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HeadcountViewComponent(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IViewComponentResult InvokeAsync()
        {
            var result = _employeeRepository.EmployeeCountByDept();
            return View(result);
        }
    }
}
