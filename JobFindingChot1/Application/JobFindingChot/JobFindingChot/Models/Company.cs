using System;
using System.Collections.Generic;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class Company
    {
        public Company()
        {
            PostJobs = new HashSet<PostJob>();
        }

        public int CompanyId { get; set; }
        public int AccountId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<PostJob> PostJobs { get; set; }
    }
}
