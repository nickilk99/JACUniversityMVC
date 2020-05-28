using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JACUniverstityMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
