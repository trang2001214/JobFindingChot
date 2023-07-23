using System;
using System.Collections.Generic;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class Account
    {
        public Account()
        {
            Companies = new HashSet<Company>();
            Employees = new HashSet<Employee>();
            PostJobs = new HashSet<PostJob>();
        }

        public int AccountId { get; set; }
        public int RoleId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int AccountStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLogin { get; set; }
        public string Salt { get; set; }

        public virtual AccountStatus AccountStatus { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PostJob> PostJobs { get; set; }
    }
}
