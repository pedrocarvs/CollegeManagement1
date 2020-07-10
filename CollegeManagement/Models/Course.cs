using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagement.Models
{
    public class Course
    {
        
            public int CourseID { get; set; }
            [DisplayName("Course Title")]
            public string Title { get; set; }
            public virtual ICollection<Subject> Subjects { get; set; }
    }
}