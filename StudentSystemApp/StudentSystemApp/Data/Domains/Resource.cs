using System.ComponentModel.DataAnnotations;

namespace StudentSystemApp.Data.Domains
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string ResourceType { get; set; }
        [MaxLength(50)]
        public int CourseId { get; set; }

    }
}
