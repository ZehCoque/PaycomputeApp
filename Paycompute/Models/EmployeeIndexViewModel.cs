using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class EmployeeIndexViewModel
    {
        //here goes what we would like to display to the controller
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateJoined { get; set; }
        public string Designation { get; set; }
        public string City { get; set; }

    }
}
