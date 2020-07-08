using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Login")]
        public string UserName { get; set; }

        [Required]
        [UIHint("Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
