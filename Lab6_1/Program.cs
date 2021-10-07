using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string longWord = "";
           
            foreach (string s in stringArray)
            {

                if (s.Length>longWord.Length)
                   {
                    longWord = s;
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", longWord);
            Console.ReadKey();
        }
    }
}
