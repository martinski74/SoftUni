// 1. Code First Student System
namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum ResourceType
    {
        Video, Presentation, Document, Other
    }
    public class Resource
    {
        public Resource()
        {
            this.Courses = new HashSet<Course>();
            this.Licenses = new HashSet<License>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(265)]
        public string Name { get; set; }

        [Required]
        public ResourceType Type { get; set; }

        [Required]
        public string Url { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
    }
}
