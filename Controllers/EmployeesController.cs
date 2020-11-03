using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using webcore.Models;
using AutoMapper;
namespace webcore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeContext _context;
      

        public EmployeesController(EmployeeContext context)
        {
            _context = context;
           
        }

        //Get Employee
        public async Task<IActionResult> Index()
        {         

           var emp= await _context.Employees.ToListAsync();
            return View(emp);
        }
        //get employee by id
       
        public async Task<IActionResult> Details(int? Id)

        {
           if(Id==null)
            {
                return NotFound();
            }
            //  var employee =await _context.Employees.FirstOrDefaultAsync(m => m.EmployeeId == Id);
            var employee =await _context.Employees.FromSqlRaw("spGetElementById {0}", Id).FirstOrDefaultAsync();
            if(employee==null)
            {
                return NotFound();

            }
            return View(employee);
        }
    }
}