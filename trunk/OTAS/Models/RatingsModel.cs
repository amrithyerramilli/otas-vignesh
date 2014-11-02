using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTAS.Models
{
    [Table("RID_TABLE")]
    public class RatingsModel
    {
        [Key]
        [Required]
        public string RID { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "1. Effective Communication and Clarity in Explanation")]
        public decimal A1 { get; set; }
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Required(ErrorMessage = "Please select an option")]
        [Display(Name = "2. Preparedness and Depth of Subject Knowledge (Relevant Practical Applications wherever applicable)")]
        public decimal A2 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "3. Time Management (Effective use of the class hour and timely coverage of syllabus)")]
        public decimal A3 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "4. Enforcement of Discipline in the class")]
        public decimal A4 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "5. Invites Questions and Encourages Thinking (Class Motivation towards Enhanced Learning)")]
        public decimal A5 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "6. Provide discussions on Problems, Programs, Assignments, Quiz, case studies/situation analysis, Exam questions and Illustrations")]
        public decimal A6 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "7. Availability, Accessibility and Approachability for clarifications outside the Class")]
        public decimal A7 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "8. Study materials such as Lecture notes, handouts, PPTs, etc.")]
        public decimal A8 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "9. Coverage of Syllabus")]
        public decimal A9 { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [Range(1, 4, ErrorMessage = "Please select an option")]
        [Display(Name = "10. Evaluation of Tests/Assignments with suggestions for Improvement")]
        public decimal A10 { get; set; }


    }
}