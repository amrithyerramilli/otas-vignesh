using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTAS.Models
{
    [Table("Teacher")]
    public class TeacherModel
    {
        [Required]
        [Key]
        [Display(Name = "ID")]
        public string TID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string TeacherName { get; set; }
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Required]
        [Display(Name = "Department")]
        public string DeptId { get; set; }
        
       
        
    }
}