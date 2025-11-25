using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RadochinaAP.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V23.txt");

            // Читаем весь текст из файла
            string text = File.ReadAllText(path);

            // Удаляем русские слова (кириллические символы)
            string result = Regex.Replace(text, @"\b[а-яА-ЯёЁ]+\b", "");

            // Убираем лишние пробелы и запятые
            result = Regex.Replace(result, @"\s+", " ");
            result = result.Trim();

            // Записываем результат в новый файл
            File.WriteAllText(outputPath, result, Encoding.UTF8);

            return outputPath;
        }
    }
}
     