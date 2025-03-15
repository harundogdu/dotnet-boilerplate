namespace efcoreApp.Data
{
    public class CourseEnrolment
    {
        public int CourseEnrolmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime CourseEnrolmentTime { get; set; }
    }
}