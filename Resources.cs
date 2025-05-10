using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Resources
    {

        [Key]
        public int ResourceId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required] // لجعل الخاصية غير قابلة للقيمة الفارغة
        [Unicode(false)]
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
