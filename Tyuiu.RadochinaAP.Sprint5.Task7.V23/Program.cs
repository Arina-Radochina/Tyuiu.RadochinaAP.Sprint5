using System;
using Tyuiu.RadochinaAP.Sprint5.Task7.V23.Lib;
namespace Tyuiu.RadochinaAP.Sprint5.Task7.V23
{
    class Program

    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V23.txt";


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный файл: " + inputPath);
            string originalText = File.ReadAllText(inputPath);
            Console.WriteLine("Исходный текст: " + originalText);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string resultPath = ds.LoadDataAndSave(inputPath);
            string resultText = File.ReadAllText(resultPath);
            Console.WriteLine("Результат: " + resultText);
            Console.WriteLine("Файл результата: " + resultPath);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}