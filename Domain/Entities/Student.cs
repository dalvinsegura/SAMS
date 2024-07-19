using Backend.Domain.Core;
using System.Security.Claims;

namespace Backend.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
