using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domains
{
    public class HomeworkSubmission
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        [MaxLength(50)]
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
