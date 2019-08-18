using DataAccessLayer.Data;
using DataAccessLayer.Models;
using EmployeeManagement.Core.Models;
using EmployeeManagement.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Data
{
    public static class DBInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            //context.Database.EnsureCreated();

            //var role = new ApplicationRole()
            //{
            //    Id = "Admin",
            //    Description = "Administrator",
            //    Name = "Admin"
            //};

            //context.ApplicationRoles.Add(role);
            //context.SaveChanges();


            var employee = new Employee()
            {
                FirstName = "Jok",
                LastName = "Garcia",
                Email = "@email.com",
                BirthDate = Convert.ToDateTime("07/09/1980"),
                IsActive = true
            };
            context.Employees.Add(employee);
            context.SaveChanges();

            var employee2 = new Employee()
            {
                FirstName = "Anthony",
                LastName = "Davis",
                Email = "@email.com",
                BirthDate = Convert.ToDateTime("07/09/1980"),
                IsActive = true
            };
            context.Employees.Add(employee2);
            context.SaveChanges();

            var d = new Department()
            {
                Name = "Acct"
            };
            context.Departments.Add(d);
            context.SaveChanges();
        }
    }
}
