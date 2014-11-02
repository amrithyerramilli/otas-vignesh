using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTAS.Models
{
    [Table("DEPT")]
    public class DepartmentModel
    {
        [Key]
        [Required]
        [Display(Name = "ID")]
        public string DeptId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Deptname { get; set; }
        //public int HOD { get; set; }
        
    }
}