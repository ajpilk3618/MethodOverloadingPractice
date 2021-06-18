using System;
using System.Collections.Generic;

namespace MethodOverloadingPractice
{
    class Program
    {
        //TODO Create a method that takes two string names in the parameter. Have the method tell you which name is longer.
        //TODO Create an overload method that takes a list of string names and an integer. The method will look for the first name that matches the length of the integer.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TODO Call both methods here. Use a break point and watch as the code jumps to the different method overloads.

            //LongestString("Adam", "John");
            LongestString();
        }

        public static void LongestString(string name1, string name2)
        {
            int name1Length = name1.Length;
            int name2Length = name2.Length;

            if (name1Length < name2Length)
            {
                Console.WriteLine(name1);
            }
            else if (name1Length > name2Length)
            {
                Console.WriteLine(name2);
            }
            else Console.WriteLine($"{name1} and {name2} are the same length");
        }

        public static void LongestString(List<string> names, int length)
        {
            foreach (var name in names)
            {
                if (name.Length == length)
                {
                    Console.WriteLine($"{name}'s length matches the given number");
                }
            }
        }
     
    }
}
