
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CollegeManagement.Models;


namespace CollegeManagement.DAL
    {

        public class CollegeInitializer : System.Data.Entity.DropCreateDatabaseAlways<CollegeContext>
        {
            protected override void Seed(CollegeContext context)
            {
                var students = new List<Student>
            {
            new Student{ID=1, RegistationNumber= 1, Name="Arturo",BirthDate=DateTime.Parse("2003-09-01")},
            new Student{ID=2, RegistationNumber= 2, Name="Gytis",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{ID=3, RegistationNumber= 3, Name="Yan",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{ID=4, RegistationNumber= 4, Name="Peggy",BirthDate=DateTime.Parse("2001-09-01")},
            new Student{ID=5, RegistationNumber= 5, Name="Laura",BirthDate=DateTime.Parse("2003-09-01")},
            };

                students.ForEach(s => context.Students.Add(s));
                context.SaveChanges();
                var teachers = new List<Teacher>
            {
            new Teacher{ID= 1, Name="Carson",BirthDate=DateTime.Parse("2005-09-01"), Salary = 1000},
            new Teacher{ID= 2,Name="Meredith",BirthDate=DateTime.Parse("2002-09-01"), Salary = 1500},
            new Teacher{ID= 3, Name="Arturo",BirthDate=DateTime.Parse("2003-09-01"), Salary = 1300},

            };

                teachers.ForEach(s => context.Teachers.Add(s));
                context.SaveChanges();

                var courses = new List<Course>
            {
            new Course{ CourseID= 1, Title="Chemistry"},
            new Course{ CourseID= 2, Title="Microeconomics"},
            new Course{ CourseID= 3, Title="Macroeconomics"},
            new Course{ CourseID= 4, Title="Calculus"},


            };

                courses.ForEach(s => context.Courses.Add(s));
                context.SaveChanges();

            var grades = new List<Grade>
            {
            new Grade{ID=1,Value=5.0},
            new Grade{ID=2,Value=10.0},
            new Grade{ID=3,Value=15.0},
            new Grade{ID=4,Value=20.0},
            };
            grades.ForEach(s => context.Grades.Add(s));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
            new Subject{SubjectID=1,Name="Chemistry1", TeacherID = 1,CourseID= 1},
            new Subject{SubjectID=2,Name="Microeconomics1",TeacherID=2,CourseID=2},
            new Subject{SubjectID=3,Name="Macroeconomics1",TeacherID=2,CourseID=2},
            new Subject{SubjectID=4,Name="Calculus1",TeacherID=3,CourseID=3},

            };
                subjects.ForEach(s => context.Subjects.Add(s));
                context.SaveChanges();

                var enrollments = new List<Enrollment>
            {
            new Enrollment{EnrollmentID = 1, StudentID=1,SubjectID=1, GradeID=1},
            new Enrollment{EnrollmentID = 2, StudentID=1,SubjectID=2, GradeID=1},
            new Enrollment{EnrollmentID = 3, StudentID=1,SubjectID=3, GradeID=2},
            new Enrollment{EnrollmentID = 4, StudentID=3,SubjectID=4, GradeID=3},
            new Enrollment{EnrollmentID = 5, StudentID=2,SubjectID=4, GradeID=3},
            new Enrollment{EnrollmentID = 6, StudentID=3,SubjectID=3, GradeID=4},

            };
                enrollments.ForEach(s => context.Enrollments.Add(s));
                context.SaveChanges();

            }
        }
    }
