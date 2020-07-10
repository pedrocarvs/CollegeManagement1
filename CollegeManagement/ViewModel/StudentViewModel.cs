using System.ComponentModel;

namespace CollegeManagement.ViewModel
{
    public class StudentViewModel
    {
        [DisplayName("Course Title")]
        public string StudentName  { get; set; }

        [DisplayName("Student Grade")]
        public double? Grade { get; set; }
       
    }
}