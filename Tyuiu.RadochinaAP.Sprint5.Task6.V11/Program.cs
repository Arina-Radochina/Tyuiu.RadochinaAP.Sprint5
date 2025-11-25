using System;
using Tyuiu.RadochinaAP.Sprint5.Task6.V11.Lib;

namespace Tyuiu.RadochinaAP.Sprint5.Task6
{
    class Program

    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";


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

            Console.WriteLine("Путь к файлу: " + path);

            string fileContent = File.ReadAllText(path);
            Console.WriteLine("Текст в файле: " + fileContent);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int result = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество слов длиной 6 символов: " + result);
            Console.ReadKey();
        }
    }
}