using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Assignment_02.Models
{
    [Table("PROFESSOR")]
    public class Professor
    {
        [Required(ErrorMessage = "Professor ID is required")]
        [Column(Order = 0, TypeName = "int")]
        [Key]
        public int PROFESSOR_ID { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(255)")]
        public string PROFESSOR_NAME { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "nvarchar(10)")]
        public string SEX { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "nvarchar(255)")]
        public string EMAIL_ID { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "int")]
        public int COURSE_ID { get; set; }
    }
}
