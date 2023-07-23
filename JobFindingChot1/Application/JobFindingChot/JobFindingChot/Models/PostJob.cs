using System;
using System.Collections.Generic;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class PostJob
    {
        public PostJob()
        {
            JobApplies = new HashSet<JobApply>();
        }

        public int PostJobId { get; set; }
        public int AccountId { get; set; }
        public int CompanyId { get; set; }
        public int CatId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public DateTime PostDate { get; set; }
        public string Location { get; set; }
        public int RequiredPerson { get; set; }
        public DateTime ApplicationLastDate { get; set; }

        public virtual Account Account { get; set; }
        public virtual Category Cat { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<JobApply> JobApplies { get; set; }
    }
}
