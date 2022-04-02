using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Assignment_02.Models
{
    [Table("RESULT")]
    public class Result
    {
        [Required(ErrorMessage = "Result ID is required")]
        [Column(Order = 0, TypeName = "int")]
        [Key]
        public int RESULT_ID { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "int")]
        public int STUDENT_ID { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "int")]
        public int JAVA { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "int")]
        public int DATABASE { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "int")]
        public int GENDERSTUDIES { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "int")]
        public int ASP_NET { get; set; }

        [Required]
        [Column(Order = 6, TypeName = "int")]
        public int JAVA_SCRIPT { get; set; }

        [Required]
        [Column(Order = 7, TypeName = "int")]
        public int MAINFRAME { get; set; }

        [Required]
        [Column(Order = 8, TypeName = "float")]
        public float PERCENTAGE { get; set; }

        [Required]
        [Column(Order = 9, TypeName = "nchar(1)")]
        public string GRADE { get; set; }
    }
}
