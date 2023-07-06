using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to count the total number of words in a string.

namespace StringExamples
{
    public class Count_Total_numb
    {
        static void Main(string[] args)
        {
            string str = "How are you?";
            Console.WriteLine(str);
            int count = 0;

            for(int i=0; i<str.Length; i++)
            {
                //Count all the spaces present in the string
                //it doesn't include the first space as if won't be considered as a word
                //IsLetter(c) condition true zali [char.IsLetter(character aala ki condition true hoil)]
                if (str[i] == ' ' && char.IsLetter(str[i+1]) && (i>0))  
                { 
                    count++;
                }
            }
            count++;

            Console.WriteLine(count);
        }
    }
}
