using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Bank:UserActivity
    {
        [Key]

        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string AccountNo { get; set; }
    }
}
