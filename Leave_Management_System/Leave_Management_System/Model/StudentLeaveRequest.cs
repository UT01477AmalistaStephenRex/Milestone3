using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leave_Management_System.Model
{
    public class StudentLeaveRequest
    {

        [Key]
        public int SLRId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; } = "nvarchar(100)";
        [Column]
        public string Reason { get; set; } = "nvarchar(500)";
        [Column]
        public string From { get; set; } = "nvarchar(10)";
        [Column]
        public string Days { get; set; } = "nvarchar(5)";
        [Column]
        public string AppliedOn { get; set; } = "nvarchar(10)";
    }
}
