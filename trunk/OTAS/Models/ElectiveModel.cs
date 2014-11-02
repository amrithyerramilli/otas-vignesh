using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTAS.Models
{
    [Table("ELECTIVE")]
    public class ElectiveModel
    {
        [Key]
        [Required]
        public string USN { get; set; }
        public string ELECTIVE1 { get; set; }
        public string ELECTIVE2 { get; set; }
        public string ELECTIVE3 { get; set; }
        public string ELECTIVE4 { get; set; }
    }
}