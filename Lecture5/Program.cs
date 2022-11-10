using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    class Program
    {
        static string GetVowels(params string []input)
        {
            if(input==null||input.Length==0)
            {
                return string.Empty;
            }
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            return string.Concat(input.SelectMany(word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
        }

        static void Example1()
        {
            string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
            Console.WriteLine($"Vowels from array : '{fromArray}'");

            string fromMultipleArguments = GetVowels("apple", "banana", "pear");
            Console.WriteLine($"Vowels from multiple arguments :'{fromMultipleArguments}'");

            string fromNull = GetVowels(null);
            Console.WriteLine($"Vowels from null :'{fromNull}'");

            string fromNoValue = GetVowels();
            Console.WriteLine($"Vowels from no value : '{fromNoValue}'");
        }
        static void ModifyValue(int variable1)
        {
            variable1 = 30;
            Console.WriteLine("In ModifyValue, variable1 = {0}", variable1);
            return;
        }
        static void Example2()
        {
            int variable1 = 245 ;
            Console.WriteLine("In Main, variable1 ={0}",variable1);
            ModifyValue(variable1);
            Console.WriteLine("Back in Main, variable1 ={0}", variable1);
        }


        
        static void Main(string[] args)
        {
            //Example1();
            //Example2();
        }
    }
}
