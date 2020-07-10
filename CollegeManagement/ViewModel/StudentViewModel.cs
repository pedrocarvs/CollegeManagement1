using System.ComponentModel;
using System.Collections.Generic;


namespace CollegeManagement.ViewModel
{
    public class StudentViewModel
    {
        [DisplayName("Student Name")]
        public string StudentName  { get; set; }

        [DisplayName("Student Grade")]
        public double? Grade { get; set; }
       
    }
}