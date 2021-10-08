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
            bool paly = true;
            foreach (char s in text)
            {
                int indSpace = text.IndexOf(space);
                if (indSpace >= 0)
                {
                    text = text.Remove(indSpace,1);
                }
            }
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    paly = false;
                } 
            } 
            {
                if (paly)
                {
                    Console.WriteLine("Предложение является палиндромом");
                }
                else
                {
                    Console.WriteLine("Предложение не является палиндромом");
                }
            }
            Console.ReadKey();
        }
    }
}
