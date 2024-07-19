using Backend.Domain.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Domain.Entities
{
    public class Attendance : BaseEntity
    {
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [ForeignKey("ClassId")]
        public int ClassId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}
