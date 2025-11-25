using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RadochinaAP.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r', '\t' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string word in words)
            {
                if (word.Length == 6)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
