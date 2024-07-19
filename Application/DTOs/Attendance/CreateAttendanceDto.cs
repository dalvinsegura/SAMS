namespace Backend.Application.DTOs.Attendance
{
    public class CreateAttendanceDto
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}
