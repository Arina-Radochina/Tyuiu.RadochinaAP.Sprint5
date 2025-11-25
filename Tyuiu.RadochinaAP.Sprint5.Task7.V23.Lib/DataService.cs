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

            string text = File.ReadAllText(path);

            // Удаляем русские слова и убираем пробелы перед знаками препинания
            string result = Regex.Replace(text, @"\b[а-яА-ЯёЁ]+\b", "");

            // Убираем лишние пробелы и пробелы перед знаками препинания
            result = Regex.Replace(result, @"\s+", " ");
            result = Regex.Replace(result, @"\s+([.,!?;:])", "$1");
            result = result.Trim();

            File.WriteAllText(outputPath, result, Encoding.UTF8);
            return outputPath;
        }
    }
}

     