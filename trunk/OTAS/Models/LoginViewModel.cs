using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OTAS.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usn")]
        public string Usn { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}