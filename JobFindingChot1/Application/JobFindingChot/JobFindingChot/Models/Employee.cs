using System;
using System.Collections.Generic;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class Employee
    {
        public Employee()
        {
            JobApplies = new HashSet<JobApply>();
        }

        public int EmployeeId { get; set; }
        public int AccountId { get; set; }
        public int CatId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Cnic { get; set; }
        public string Fnic { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }
        public string AttachCv { get; set; }
        public string Description { get; set; }

        public virtual Account Account { get; set; }
        public virtual Category Cat { get; set; }
        public virtual ICollection<JobApply> JobApplies { get; set; }
    }
}
