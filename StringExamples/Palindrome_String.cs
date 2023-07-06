using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check whether a given string is palindrome or not.

namespace StringExamples
{
    public class Palindrome_String
    {
        static void Main(string[] args)
        {
            string str = "nitin";

            string str2= string.Empty;
            for (int i = str.Length-1; i >= 0; i--)
            {
                str2 += str[i];
            }
            if(str2==str)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
    }
}
