using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RadochinaAP.Sprint5.Task2.V26.Lib
{
    public class DataService : ISprint5Task2V26
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0); 
            int columns = matrix.GetLength(1); 

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    
                    if (matrix[i, j] > 0)
                    {
                        str += "1";
                    }
                    else
                    {
                        str += "0";
                    }

                    if (j != columns - 1)
                    {
                        str += ";";
                    }
                }

                if (i != rows - 1)
                {
                    str += Environment.NewLine;
                }
            }

            File.WriteAllText(path, str);
            return path;
        }
    }
}