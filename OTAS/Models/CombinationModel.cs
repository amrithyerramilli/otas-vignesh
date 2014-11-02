using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTAS.Models
{
    [Table("SubComb")]
    public class CombinationModel
    {
        [Key]
        [Required]
        public string CombId { get; set; }
        [Required]
        public string TID { get; set; }
        [Required]
        public string SubCode { get; set; }
        [Required]
        public int Sem { get; set; }
        [Required]
        public string DeptId { get; set; }
        [Required]
        public string Section { get; set; }

        public decimal CGPA { get; set; }
        public bool Elective { get; set; }
        [Required]
        public int Count { get; set; }
        public decimal Percentile { get; set; }
        

    }
}