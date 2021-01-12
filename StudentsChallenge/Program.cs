using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                Console.WriteLine("Welcome to Jordan High, new students go to the Administration Office");
                Console.ReadLine();
                
                Console.WriteLine("Fill out this form please.");

                Student student1 = new Student();

                Console.WriteLine("What is your name?");
                
                student1.StudentFName = Console.ReadLine();

                Console.WriteLine("Enter your last name.");
                student1.StudentLName = Console.ReadLine();

                Console.WriteLine("Are you a Freshman, Sophmore, Junior, or Senior?");
                Grade grade1 = new Grade();
                grade1.GradeName = Console.ReadLine();

                Console.WriteLine("Enter class number. Ex(9, 10, 11, 12)");
                grade1.GradeNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Does this information look correct?");
                Console.WriteLine(student1.StudentFName + student1.StudentLName);
                Console.WriteLine(grade1.GradeName + grade1.GradeNum);

                db.Students.Add(student1);
                db.Grades.Add(grade1);
                db.SaveChanges();

               
            }
            
        }
    }
}
