using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ввести с клавиатуры предложение. Предложение представляет собой слова, 
 * разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск самого длинного слова в предложении");
            Console.WriteLine();
            Console.WriteLine("Введите предложение");
            string inputString = Console.ReadLine();

            string[] strArray = inputString.Split();
            string longestWord = "";

            foreach (string str in strArray)
            {
                if (str.Length > longestWord.Length)
                {
                    longestWord = str;
                }
            }

            Console.WriteLine("Самое длинное слово - {0}", longestWord);
            Console.ReadKey();
        }
    }
}
