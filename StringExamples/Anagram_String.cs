using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
   public class Anagram_String
    {
        static void Main(string[] args)
        {
            string str = "listen";
            string str1 = "silent";

            char[] ch = str1.ToLower().ToCharArray();
            char[] ch1= str1.ToLower().ToCharArray();

            Array.Sort(ch);
            Array.Sort(ch1);

            string value = new string(ch);
            string value1 = new string(ch1);

            if(value == value1 )
            {
                Console.WriteLine("Both are Anagram");
            }
            else
            {
                Console.WriteLine("Both are not Anagram");
            }
        }
    }
}
