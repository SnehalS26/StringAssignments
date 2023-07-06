using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class Longest_word_String
    {
        static void Main(string[] args)
        {
            string str = "Hello all Good Morning";
            string[] str1 = str.Split(new [] {" "} , StringSplitOptions.None);

            int count = 0;
            string word = string.Empty;

            foreach(string s in str1)
            {
                if(s.Length > count)
                {
                    count = s.Length;
                    word = s;
                }
            }
            Console.WriteLine($"Longest word is {word} And Length is {count}");
        }
    }
}
