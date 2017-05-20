using System;

namespace MSBuildTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new ClassLibrary1.Class1();
            b.Add(1,2);
            Console.ReadLine();
        }
    }
}
