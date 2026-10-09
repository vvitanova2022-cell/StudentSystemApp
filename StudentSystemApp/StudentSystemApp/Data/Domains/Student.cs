using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domains
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(100)]
        public int PhoneNumber { get; set; }
        [MaxLength (10)]
        [MinLength(10)]

        public int RegisteredOn { get; set; }
        public int Birthday { get; set; }
        public virtual IEnumerable<HomeworkSubmission> HomeworkSubmissions { get; set; } = new List<HomeworkSubmission>();
        public virtual IEnumerable<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
