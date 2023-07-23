using System;
using System.Collections.Generic;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class JobApplyStatus
    {
        public JobApplyStatus()
        {
            JobApplies = new HashSet<JobApply>();
        }

        public int JobApplyStatusId { get; set; }
        public string JobApplyStatus1 { get; set; }

        public virtual ICollection<JobApply> JobApplies { get; set; }
    }
}
