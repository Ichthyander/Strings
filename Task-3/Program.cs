using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. В строке может быть несколько фрагментов, 
* заключённых в фигурные скобки. Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.*/

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Удаление текста в фигурных скобках");
            Console.WriteLine();
            Console.WriteLine("Введите предложение");
            //string inputString = Console.ReadLine();
            StringBuilder inputString = new StringBuilder(Console.ReadLine());

            StringTrimmer(inputString);

            Console.WriteLine("Конвертированный текст: {0}", inputString);
            Console.ReadKey();
        }

        //Рекурсивный метод-обработчик строк
        public static StringBuilder StringTrimmer (StringBuilder inputString)
        {
            int startPosition = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                //Если {, то назначаем стартовую позицию
                if (inputString[i] == '{')
                {
                    startPosition = i;
                }
                //Если }, то удаляем 
                if (inputString[i] == '}')
                {
                    int endPosition = i;
                    StringTrimmer(inputString.Remove(startPosition, endPosition - (startPosition - 1)));
                    break;
                }
            }
            return inputString;
        }
    }

}
