using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.*/

            List<Course> courses = new List<Course>();

            courses.Add(new Course { CourseId = 1, Name = "Calculus 301",Students = new List<Student>() {
            new Student {StudentId = 1, Name = "John Eisen" },
            new Student {StudentId = 2, Name = "Rachel Connor" } } });
            courses.Add(new Course { CourseId = 2, Name = "Chemistry 202", Students = new List<Student>(){
            new Student {StudentId = 3, Name = "Greg Anderson"},
            new Student { StudentId = 4, Name = "Anne Becker"  } }
            });
            courses.Add(new Course{CourseId = 3,Name = "French 103", Students = new List<Student>(){
            new Student {StudentId = 5, Name = "Roberta Polanski" },
            new Student {StudentId = 6, Name = "Jack Hernandez"} }
            });


            foreach (Course subject in courses)
            {
                resultLabel.Text += string.Format("<br/>Course: {0} - {1}", subject.CourseId, subject.Name);

                foreach (var student in subject.Students)
                {
                    resultLabel.Text += string.Format("<br/>&nbsp&nbspStudent: {0} - {1}", student.StudentId, student.Name);
                }
            }

        }


        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in. */


            Dictionary<int,Student> students = new Dictionary<int, Student>()
        {
           {1, new Student {StudentId = 1, Name = "John Eisen", Courses = new List <Course>() {
             new Course {CourseId= 1, Name = "Calculus 301" },
             new Course {CourseId = 4, Name = "Computer Basics 101" } } } } ,
           {2, new Student {StudentId = 2, Name = "Rachel Connor", Courses = new List<Course>() {
             new Course {CourseId = 1, Name = "Calculus 301" } ,
             new Course {CourseId = 3, Name = "French 103" } } } },
           {3, new Student {StudentId = 3, Name =  "Greg Anderson", Courses= new List<Course>(){
             new Course {CourseId = 2, Name = "Chemistry 202" },
             new Course {CourseId = 5, Name = "Economics 102" } } } }
         };

            foreach (var student in students)
              {
                resultLabel.Text += string.Format(" <br/>Student: {0} - {1}", student.Value.StudentId, student.Value.Name);

                foreach (Course course in student.Value.Courses)
                  {
                    resultLabel.Text += string.Format("<br/>&nbsp&nbspCourse:{0} {1}", course.CourseId, course.Name);
                  }
             }
       }


        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade. */



            List<Student> students = new List<Student>();
            
                students.Add(new Student { StudentId = 5, Name = "Jennifer Franklin" });
                students.Add(new Student { StudentId = 7, Name = "Mark Patterson" });


            List<Subject> subjects = new List<Subject>()
             {
              
               new Subject {Grade = 89, StudentName =  new Student{Name = "Jennifer Franklin"}, CourseName= new Course {Name = "BioChemistry 101" } } ,
               new Subject {Grade = 95, StudentName = new Student{Name= "Jennifer Franklin"}, CourseName = new Course {Name ="Greek 200"} },
               new Subject {Grade = 94, StudentName = new Student {Name = "Mark Patterson"}, CourseName = new Course {Name = "Ancient History 214" } },
               new Subject {Grade = 91, StudentName = new Student {Name = "Mark Patterson"}, CourseName =  new Course {Name = "Statistics 142" } }
            }; 
            foreach (var student in students)
            {
                resultLabel.Text += string.Format("<br/> Student: {0} {1}", student.StudentId, student.Name);

                foreach (var subject in subjects)

                {
                    if (subject.StudentName.Name == student.Name)
                    {
                        resultLabel.Text += string.Format("<br/>Enrolled In: {0} - Grade:{1}", subject.CourseName.Name, subject.Grade);
                    }
                }

             }

          }
      }
 }

 
  