using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [MaxLength(80)]
        [Required]
        public string name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<StudentCorse> StudentCourses { get; set; } = new HashSet<StudentCorse>();
        public ICollection<Resources> Resources { get; set; } = new HashSet<Resources>();
        public ICollection<HomeworkSubmissions> HomeworkSubmissions { get; set; } = new HashSet<HomeworkSubmissions>();


    }

}
