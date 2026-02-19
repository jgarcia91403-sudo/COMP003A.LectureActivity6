
namespace COMP003A.LectureActivity6
{
  using System;
 public class student
        {
            public string Name;
            public int Age;
            public student(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
         internal class program
        {
            static void Main(string[] args)
            {
                student student1 = new student("Joseph", 23);
                student student2 = new student("Braxton", 30);
                student1.DisplayInfo();
                student2.DisplayInfo();
                Console.WriteLine("\nAfter modifying student1 age run DisplayInfo again:\n");
                student1.Age = 40;
                student1.DisplayInfo();
                student2.DisplayInfo();
        }
    }
}
