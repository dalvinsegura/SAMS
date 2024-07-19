namespace Backend.Application.DTOs.Attendance
{
    public class AttendanceDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public StudentDto Student { get; set; }
        public int ClassId { get; set; }
        public ClassDto Class { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}
