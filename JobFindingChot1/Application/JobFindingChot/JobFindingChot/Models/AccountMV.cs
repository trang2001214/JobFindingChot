using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobFindingChot.Models
{
    public class AccountMV
    {
        public AccountMV()
        {
            Company = new CompanyMV();
        }
        public int AccountId { get; set; }
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Required*")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Required*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required*")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Required*")]
        public string Password { get; set; }
        public bool AreYouProvider { get; set; }
        

        public int AccountStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLogin { get; set; }
        public string Salt { get; set; }
        public CompanyMV Company { get; set; }
    }
}
