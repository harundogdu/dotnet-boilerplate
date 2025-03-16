using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course title")]
        public string? CourseTitle { get; set; }
    }
}