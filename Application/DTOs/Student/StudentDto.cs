using Backend.Application.DTOs.Attendance;
using Backend.Application.DTOs.Class;

namespace Backend.Application.DTOs.Student
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<ClassDto> Classes { get; set; }
        public ICollection<AttendanceDto> Attendances { get; set; }
    }
}
