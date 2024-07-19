using Backend.Application.DTOs.Class;

namespace Backend.Application.DTOs.Teacher
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<ClassDto> Classes { get; set; }
    }
}
