using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagement.ViewModel
{
    public class CourseViewModel
    {

        public int CourseId { get; set; }

        [DisplayName("Course Title")]
        public string Title { get; set; }
        [DisplayName("Number of Teachers")]
        public int TotalTeachers { get; set; }
        [DisplayName("Number of Students")]
        public int TotalStudents { get; set; }

        [DisplayName("Average Grade")]
        public double? AvgGrade { get; set; }

    }
}