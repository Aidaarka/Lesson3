using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace lesson3.Char
{
    class Second
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' });

            int a = 0;
            int letter = 0;
            string result;

            char[] split = text.ToCharArray();
            int size = split.Length;

            foreach (string s in words)
            {
                a = (words.Length - 1);
            }

            for (int n = 0; n < size; n++)
            {
                if (char.IsLetter(split[n])) ++letter;
            }

            double percent = ((double)a / letter)*100;
            result = string.Format("{0:0.00}", percent);

            Console.WriteLine("Количество последних букв в тексте составило: {0}%", result);
        }
    }
}
