
namespace COMP003A.LectureActivity6
{
  using System;
 public class student // this is the student class which will have the name and age of the student
        {
            public string Name;
            public int Age;
            public student(string name, int age) // this is the constructor for the student class which will initialize the name and age of the student
            {
                Name = name;
                Age = age;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}"); // this will display the name and age of the student
            }
        }
         internal class program // this is the main program class
        {
            static void Main(string[] args)
            {
                student student1 = new student("Joseph", 23);
                student student2 = new student("Braxton", 30);
                student1.DisplayInfo(); // this the info for student1
                student2.DisplayInfo();// this will also display the info for student2
                Console.WriteLine("\nAfter modifying student1 age run DisplayInfo again:\n");
                student1.Age = 40; // this will change the age of student1 to 40
                student1.DisplayInfo();
                student2.DisplayInfo();
        }
    }
}
