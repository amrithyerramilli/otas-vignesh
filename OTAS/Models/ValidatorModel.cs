using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTAS.Models
{
    [Table("ValidS")]
    public class ValidatorModel
    {
        [Required]
        [Key]
        [Display(Name = "USN")]
        public string USN { get; set; }
        [Display(Name = "Password")]
        public string PASSGEN { get; set; }
        [Required]
        public int COUNTER { get; set; }
        [Required]
        public bool FG { get; set; }
        [Required]
        public bool STUDENTDETAILS { get; set; }
    }
}