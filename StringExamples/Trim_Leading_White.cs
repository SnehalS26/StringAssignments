using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to trim leading white space characters in a string.

namespace StringExamples
{
    public class Trim_Leading_White
    {
        static void Main(string[] args)
        {
            string str = "     Hello Everyone";
            Console.WriteLine(str);
            str = str.Trim();
            Console.WriteLine("After Trim");
            Console.WriteLine(str);

        }
    }
}
