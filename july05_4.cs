/**4. Create a new C # project with three classes plus another class to test the logic in your code.**/

using System;

namespace july
{
    //Declaring public class studentprofessortest 
    public class StudentProfessorTest
    {
        // Main method
        public static void Main()
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
            Console.WriteLine("I'm studying on the screen");
        }
        
        public void ShowAge()
        {
            Console.WriteLine("My age is: 22 years old on the screen");
        }
    }
    
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining on the screen");
        }
    }
}


/**
Output : 
------------------
Hello!
Hello!
My age is: 22 years old on the screen
I'm studying on the screen
Hello!
I'm explaining on the screen
**/