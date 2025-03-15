using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Student
    {
        [Key] // Primary Key: Herhangi bir key'in primary key olduğunu belirtir. "classAdıId" veya "Id" olarak yazılırsa bunun eklenmesine gerek yoktur.
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime BirthTime { get; set; }
    }
}