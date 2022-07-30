using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. 
 * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).*/

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение палиндромности строки");
            Console.WriteLine();
            Console.WriteLine("Введите предложение");
            string inputString = Console.ReadLine();

            //Convert input string to string without spaces
            string convertedString = inputString.Replace(" ","");
            string invertedString = "";

            //Invert converted string
            foreach(char c in convertedString)
            {
                invertedString = c + invertedString;
            }

            //???
            //PROFIT
            string message = invertedString == convertedString ? "Это палиндром" : "Это не палиндром :(";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
