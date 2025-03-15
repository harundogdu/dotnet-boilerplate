namespace efcoreApp.Data
{
    public class CourseEnrollment
    {
        public int CourseEnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime CourseEnrollmentTime { get; set; }
    }
}