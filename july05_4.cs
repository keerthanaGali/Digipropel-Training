/**4. Create a new C # project with three classes plus another class to test the logic in your code.**/

using System;

namespace july
{
    //Declaring public class studentprofessortest 
    public class StudentProfessorTest
    {
        // Main method
        public static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Greet();
            
            Student myStudent = new Student();
            myStudent.SetAge(22);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();
            
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(45);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
    // Declaring public class Person 
    public class Person
    {
        int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
    
     // Taking Student and Teacher classes inherit from the Person class
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        
        public void ShowAge()
        {
            Console.WriteLine("My age is 22 years old");
        }
    }
    
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}


/**
Output : 
------------------
Hello!
Hello!
My age is 22 years old
I'm studying
Hello!
I'm explaining
**/