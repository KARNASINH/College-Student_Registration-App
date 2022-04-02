using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Assignment_02.Models
{
    [Table("STUDENT")]
    public class Student
    {
        [Required(ErrorMessage = "Student ID is required")]
        [Range(10000000, 99999999)]
        [Column(Order = 0, TypeName = "float")]
        [Key]
        public float STUDENT_ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)", Order = 1)]
        public string FIRST_NAME { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)", Order = 2)]
        public string LAST_NAME { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "nvarchar(12)")]
        public string PHONE_NUMBER { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "nvarchar(255)")]
        public string DOB { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "nvarchar(255)")]
        public string GENDER { get; set; }

        [Required]
        [Column(Order = 6, TypeName = "int")]
        public int ENROLLMENT_YEAR { get; set; }

        [Required]
        [Column(Order = 7, TypeName = "nvarchar(255)")]
        public string ADDRESS { get; set; }
    }
}
