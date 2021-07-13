/**4.Create a class to store details of student like rollno, name, course joined and fee paid so far. Assume courses are C# and ASP.NET with course fees being 2000 and 3000.**/

using System;

namespace july
{
    class july07_4
    {
        //Main Method
        static void Main(string[] args)
        {
            //Display the stu1 rollno,name,course on screen
            Student1 stu1 = new Student1(05, "keerthi", "c#");
            stu1.Payment(1000);
            stu1.Print(); 
            Console.WriteLine(stu1.DueAmount);
            //Display the stu2 rollno,name,course on screen
            Student1 stu2 =new Student1(31, "Vineeth", "ASP.Net");
            stu2.Payment(1000);
            stu2.Print();
            Console.WriteLine(stu2.DueAmount);
        }
        //Declaring a class student1
        public class Student1
        {
            private int rollno;
            private string name;
            private string course;
            private int feepaid;
            private static double servicetax = 12.3;
            public Student1(int rollno, string name, string course)
            {
                this.rollno = rollno;
                this.name = name;
                this.course = course;
            }
            
            public void Payment(int amount)
            {
                feepaid += amount;
            }
            public void Print()
            {
                Console.WriteLine(rollno);
                Console.WriteLine(name);
                Console.WriteLine(course);
                Console.WriteLine(feepaid);
            }
            
            public int DueAmount
            {
                get
                {
                    return TotalFee - feepaid;
                }
            }
            
            public int TotalFee
            {
                get
                {
                    double total = course == "c#,ASP.Net" ? 2000 : 3000;
                    total = total + total * servicetax / 100;
                    return (int) total;
                }
            }
            
            public static double  ServiceTax
            {
                get
                {
                    return servicetax;
                }
                set
                {
                    servicetax = value;
                }
            }
            
        }
    }
}   
   
    				
/**
Output : 
----------------
5
keerthi
c#
1000
2369

31
Vineeth
ASP.Net
1000
2369
**/