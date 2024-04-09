using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class LeaveType:UserActivity
    {
        [Key]

        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}
