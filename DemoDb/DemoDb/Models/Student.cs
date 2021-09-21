using System.ComponentModel.DataAnnotations;

namespace DemoDb.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string Studentname { get; set; }
        public string Address { get; set; }
    }
}