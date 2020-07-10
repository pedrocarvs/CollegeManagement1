using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagement.Models
{
    public class Student
    {
        public int ID { get; set; }
        public int RegistationNumber { get; set; }
        [DisplayName("Student Name")]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}