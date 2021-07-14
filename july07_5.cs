/**5. Create the classes required to store data regarding different types of Courses. All courses have name, duration and course fee. Some courses are part time where you have to store the timing for course. Some courses are onsite where you have to store the company name and the no. of candidates for the course. 
For onsite course we charge 10% more on the course fee. For part-time course, we offer 10% discount.**/

using System;

namespace july
{
    class july07_5
    {
        //Main Method
        static void Main(string[] args)
        {
            Course course1 = new OnsiteCourse("ASP.NET", 60, 7000, "Udemy", 10);
            course1.Print();
            Console.WriteLine(course1.GetTotalFee());
            
            Course course2 = new ParttimeCourse("C#", 30, 10000, "10am-12pm");
            course2.Print();
            Console.WriteLine(course2.GetTotalFee());
        }
            // Declaring a abstract class course 
             abstract class Course
            {
            
                protected string name;
                protected int duration;
                protected int coursefee;
                //Parameterized Constructor
                public Course(string name, int duration, int coursefee)
                {
                    this.name = name;
                    this.duration = duration;
                    this.coursefee = coursefee;
                }
                public virtual void Print()
                {
                    Console.WriteLine(name);
                    Console.WriteLine(duration);
                    Console.WriteLine(coursefee);
                }
                //Declaring abstract method
                public abstract int  GetTotalFee();
            }
        
            class ParttimeCourse : Course
            {
                private string timings;
                public ParttimeCourse(string name, int duration, int coursefee, string timings) : base(name,duration,coursefee)
                {
                    this.timings = timings;
                }
                public override void Print()
                {
                    base.Print();
                    Console.WriteLine(timings);
                }
                public override int GetTotalFee()
                {
                    //10% discount
                    return (int)  (coursefee * 0.90);
                }
            }
            //Declaring class onsitecourse using inheritance concept
            class OnsiteCourse : Course 
            {
                private string company;
                private int noStudents;
                public OnsiteCourse(string name, int duration, int coursefee, string company, int noStudents): base(name, duration, coursefee)
                {
                    this.company = company;
                    this.noStudents = noStudents;
                }
                public override void Print()
                {
                    base.Print();
                    Console.WriteLine(company);
                    Console.WriteLine(noStudents);
                }
                
                public override int GetTotalFee()
                {
                    return (int)(coursefee * 1.1);
                }
            }
            
    }
}
    
    				
/**
Output : 
----------------
ASP.NET
60
7000
Udemy
10
7700
C#
30
10000
10am-12pm
9000
**/