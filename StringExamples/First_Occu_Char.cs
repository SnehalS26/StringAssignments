using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to find the first occurrence of a character in a given string.

namespace StringExamples
{
    public class First_Occu_Char
    {
        static void Main(string[] args)
        {
            string str = "Hello Good Evening";

            Console.WriteLine("Enter any Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            char[] arr = str.ToCharArray();

            int a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (ch == arr[i])
                {
                    a=1;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("The Character not found....");
            }
        }
    }
}
