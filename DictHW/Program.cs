using System;

namespace DictHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> CourseList = new MyDict<int, string>();
            CourseList.Add(101, "Fundementals of CS");
            CourseList.Add(102, "C#");

            CourseList.Items();

        }
    }
}
