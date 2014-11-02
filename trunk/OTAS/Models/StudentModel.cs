using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace OTAS.Models
{
    [Table("STUDENT")]
    public class StudentModel
    {
        [Key]
       // public int ID { get; set; }
        [Required]
        [Display(Name = "USN")]
        public string USN { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string NAME { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        public string DOB { get; set; }
        [Display(Name = "Father's name")]
        public string FATHERNAME { get; set; }
        [Display(Name = "Mother's name")]
        public string MOTHERNAME { get; set; }
        [Display(Name = "Guardian's name")]
        public string GUARDIANNAME { get; set; }
        [Display(Name = "Permanent Address")]
        public string PERM_ADDRESS { get; set; }
        [Display(Name = "Local Address")]
        public string LOC_ADDRESS { get; set; }
        [Display(Name = "Mobile Number")]
        public string MOBILE { get; set; }
        [Display(Name = "Parent's contact number")]
        public string PRIMARY_CONTACT { get; set; }
        [Display(Name = "Department")]
        [Editable(false)]
        public string DeptId { get; set; }
        [Display(Name = "Semester")]
        [Editable(false)]
        public int Sem { get; set; }
        [Display(Name = "Section")]
        [Editable(false)]
        public string Section { get; set; }
        [Display(Name = "E-mail")]
        public string EMail { get; set; }
        [Display(Name = "10th Marks/CGPA")]
        public decimal? SSLC { get; set; }
        [Display(Name = "12th / Diploma Marks")]
        public decimal? PUC { get; set; }
        [Display(Name = "Batch")]
        public string Batch { get; set; }
       
    }
}