using Backend.Application.DTOs.Attendance;

namespace Backend.Application.DTOs.Class
{
    public class ClassDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public TeacherDto Teacher { get; set; }
        public ICollection<StudentDto> Students { get; set; }
        public ICollection<AttendanceDto> Attendances { get; set; }
    }
}
