using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();
            char space = ' ';
            bool poly = true;
            foreach (char s in text)
            {
                int indSpace = text.IndexOf(space);
                if (indSpace > 0)
                {

                    text = text.Remove(indSpace,1);
                }
            }
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    poly = false;
                } 
            } 
            {
                if (poly)
                {
                    Console.WriteLine("Предложение является полиндромом");
                }
                else
                {
                    Console.WriteLine("Предложение не является полиндромом");
                }
            }
            Console.ReadKey();
        }
    }
}
