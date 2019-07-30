using DataAccessLayer.Models;
using EmployeeManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee employee {get; set;}
        public Department department { get; set; }

        public IList<Department> departments { get; set; }
    }
}
