using DataAccessLayer.Models;
using EmployeeManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.ViewModels
{
    public class AccountabilityViewModel
    {
        public Accountability Accountability {get; set;}

        public Employee Employee { get; set; }
    }
}
