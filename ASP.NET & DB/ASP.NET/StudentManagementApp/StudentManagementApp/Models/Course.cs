namespace StudentManagementApp.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string? Name { get; set; }
        public string? LecturerName { get; set; }

        public virtual ICollection<Student>? Students { get; set; }
    }
}
