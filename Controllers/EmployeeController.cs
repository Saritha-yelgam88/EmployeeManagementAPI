using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Data;
using EmployeeManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET/api/employees - Retrieve all employees
        [HttpGet]
        public ActionResult<IEnumerable<Worker>> GetEmployees()
        {
            return Ok(_context.Workers.Where(w => w.WorkerType == "Employee").ToList());
        }

        // POST/api/employees - Add a new employee
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee) 
        {
            if (employee.WorkerType != "Employee")
                return BadRequest("Only employees can be added here.");

            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok("Employee added successfully.");
        }

    }
}
