using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domains
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(80)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public decimal Price { get; set; }
        public virtual IEnumerable<Resource> Resources { get; set; } = new List<Resource>();
        public virtual IEnumerable<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public virtual IEnumerable<HomeworkSubmission> HomeworkSubmissions { get; set; } = new List<HomeworkSubmission>();
    }
}
