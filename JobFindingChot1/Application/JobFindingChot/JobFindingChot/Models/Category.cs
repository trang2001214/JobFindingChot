using System;
using System.Collections.Generic;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class Category
    {
        public Category()
        {
            Employees = new HashSet<Employee>();
            PostJobs = new HashSet<PostJob>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PostJob> PostJobs { get; set; }
    }
}
