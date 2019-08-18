using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Accountability
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [StringLength(512)]
        public string Description { get; set; }
    }
}
