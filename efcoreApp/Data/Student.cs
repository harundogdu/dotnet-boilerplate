using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Student
    {
        [Key] // Primary Key: Herhangi bir key'in primary key olduğunu belirtir. "classAdıId" veya "Id" olarak yazılırsa bunun eklenmesine gerek yoktur.
        public int StudentId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public DateTime BirthTime { get; set; }
    }
}