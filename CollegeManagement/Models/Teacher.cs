using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagement.Models
{
    public class Teacher
    {
      
        public int ID { get; set; }
        [DisplayName("Teacher Name")]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}