using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COMP2084_Assignment_02.Models
{
    [Table("COURSE_ENROLLMENT")]
    public class CourseEnrollment
    {
        [Required(ErrorMessage = "Enrollment ID is required")]
        [Column(Order = 0, TypeName = "int")]
        [Key]
        public int ENROLLMENT_ID { get; set; }

        [Required(ErrorMessage = "Course Enrollment ID is required")]
        [Column(Order = 1, TypeName = "int")]
        public int COURSE_ENROLLMENT_ID { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "int")]
        public int STUDENT_ID { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "int")]
        public int COURSE_ID { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "nvarchar(10)")]
        public string DAY { get; set; }

        [Required]
        [Column(Order = 5, TypeName = "nvarchar(10)")]
        public string ENROLLMENT { get; set; }
    }
}
