using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char braceStart = '{';
            char braceEnd = '}';
            string text = Console.ReadLine();
            string result = "";



            while (text.Length > 0)
            {
                if ((text.IndexOf(braceStart) >= 0) && (text.IndexOf(braceEnd) >= 0))
                {
                    result += text.Substring(0, text.IndexOf(braceStart));
                    text = text.Remove(0, text.IndexOf(braceEnd) + 1);
                }
                else
                {
                    result += text.Substring(0);
                    text = text.Remove(0);
                }


            }


            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
