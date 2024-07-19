using Backend.Domain.Core;
using System.Security.Claims;

namespace Backend.Domain.Entities
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
