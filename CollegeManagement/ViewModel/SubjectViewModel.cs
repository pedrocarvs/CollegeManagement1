using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagement.ViewModel
{
    public class SubjectViewModel
    {

        public int SubjectID { get; set; }

        [DisplayName("Subject Name")]
        public string SubjectName { get; set; }

        [DisplayName("Teacher Name")]
        public string TeacherName { get; set; }
      
        [DisplayName("Teacher BirthDate")]
        public DateTime TeacherBirthDate { get; set; }

        public decimal? TeacherSalary { get; set; }

        [DisplayName("Number of Students")]
        public int TotalStudents { get; set; }

        [DisplayName("Students Enrolled and Their Grades")]
        public List<StudentViewModel> StudentGrades { get; set; }

    }
}