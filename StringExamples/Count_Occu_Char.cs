using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to count occurrences of a character in a given string.

namespace StringExamples
{
    public class Count_Occu_Char
    {
        static void Main(string[] args)
        {
            string str = "Hello Good Evening";

            Console.WriteLine("Enter any Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            char[] arr = str.ToCharArray();

            int count = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if (ch == arr[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
