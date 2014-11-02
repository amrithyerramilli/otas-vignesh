using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTAS.Models
{
    [Table("Subject")]
    public class SubjectModel
    {
        [Key]
        [Required]
        [Display(Name = "Subject Code")]
        public string SubCode { get; set; }
        [Required]
        [Display(Name = "Subject Name")]
        public string SubName { get; set; }
        [Required]
        [Display(Name = "Semester")]
        public int Sem { get; set; }
        [Required]
        [Display(Name = "Department")]
        public string DeptId { get; set; }
        
        
    }
}