using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobFindingChot.Models
{
    public class AccountLoginMV
    {
        [Required(ErrorMessage = "Required*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required*")]
        public string Password { get; set; }
    }
}
