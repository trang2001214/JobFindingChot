using System;
using System.Collections.Generic;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class JobApply
    {
        public int JobApplyId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime JobApplyDateTime { get; set; }
        public int JobApplyStatusId { get; set; }
        public DateTime JobApplyStatusUpdateDate { get; set; }
        public string JobApplyStatusUpDateReason { get; set; }
        public int PostJobId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual JobApplyStatus JobApplyStatus { get; set; }
        public virtual PostJob PostJob { get; set; }
    }
}
