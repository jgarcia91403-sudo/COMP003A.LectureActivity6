namespace COMP003A.LectureActivity6
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class student
        {

            public string Name;
            public int Age;
 public student (string name, int age)
        {
            name = name;
            age = age;
        }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
    }
}
