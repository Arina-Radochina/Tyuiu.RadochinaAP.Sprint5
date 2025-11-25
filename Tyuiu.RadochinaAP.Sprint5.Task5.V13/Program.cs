using System;
using Tyuiu.RadochinaAP.Sprint5.Task5.V13.Lib;

namespace Tyuiu.RadochinaAP.Sprint5.Task5.V13
{
    class Program

    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V13.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Путь к файлу: " + path);

            string fileContent = File.ReadAllText(path);
            Console.WriteLine("Данные в файле: " + fileContent);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение чисел от -1.5 до 1.5: " + result);
            Console.ReadKey();
        }
    }
}