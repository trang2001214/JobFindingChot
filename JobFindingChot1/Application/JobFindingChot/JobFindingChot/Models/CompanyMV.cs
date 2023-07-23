using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobFindingChot.Models
{
    public class CompanyMV
    {
        public int CompanyId { get; set; }
        public int AccountId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
    }
}
