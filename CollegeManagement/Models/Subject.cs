using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagement.Models
{
    public class Subject
    {
      
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }
        public int CourseID { get; set; }
      
        [DisplayName("Subject Name")]
        public string Name { get; set; }
    
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    }
}