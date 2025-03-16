using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcoreApp.Data
{
    public class Student
    {
        [Key] // Primary Key: Herhangi bir key'in primary key olduğunu belirtir. "classAdıId" veya "Id" olarak yazılırsa bunun eklenmesine gerek yoktur.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string? PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Birth date")]
        public DateTime BirthTime { get; set; }
    }
}