using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagement.Models
{
    public class Enrollment
    {
     
        public int EnrollmentID { get; set; }
            public int SubjectID { get; set; }
            public int StudentID { get; set; }
            public int GradeID { get; set; }
        
            public virtual Grade Grade { get; set; }
         
            public virtual Subject Subject { get; set; }
            
            public virtual Student Student { get; set; }
        }
}