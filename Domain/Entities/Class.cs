using Backend.Domain.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Domain.Entities
{
    public class Class : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
