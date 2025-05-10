using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [MaxLength(100)]
        [Required]//عشان مش يكون في حاجه فضيا
        public string name { get; set; }
        [Required]
        [MaxLength(10)]
        [Unicode(false)]
        public string phoneNumber { get; set; }
        public DateTime birthday { get; set; }
        public DateTime? registeredOn { get; set; }
        
    }
}
