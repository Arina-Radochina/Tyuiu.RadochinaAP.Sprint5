using Tyuiu.RadochinaAP.Sprint5.Task0.V10.Lib;

namespace Tyuiu.RadochinaAP.Sprint5.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                          *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                                   *");
            Console.WriteLine("* Задание #0                                                                                         *");
            Console.WriteLine("* Вариант #10                                                                                        *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                     *");
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                           *");
            Console.WriteLine("* Дано выражение, нужно вычислить его значение при x = 2,                                            *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль.                     *");
            Console.WriteLine("*                                                                                                    *");
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                   *");
            Console.WriteLine("******************************************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                         *");
            Console.WriteLine("******************************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
