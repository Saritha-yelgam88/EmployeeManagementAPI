using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagementAPI.Controllers;
using EmployeeManagementAPI.Data;
using EmployeeManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Tests
{
    public class EmployeesControllerTests
    {
        private ApplicationDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            return new ApplicationDbContext(options);
        }

        [Fact]
        public void GetEmployees_ReturnsEmployees()
        {
            var context = GetDbContext();
            context.Workers.Add(new Employee { Id = 1, FirstName = "Saritha", LastName = "Yelgam", WorkerType = "Employee", PayPerHour = 20.0m });
            context.SaveChanges();

            var controller = new EmployeesController(context);
            var result = controller.GetEmployees();

            Assert.IsType<OkObjectResult>(result);
        }
    }
}
