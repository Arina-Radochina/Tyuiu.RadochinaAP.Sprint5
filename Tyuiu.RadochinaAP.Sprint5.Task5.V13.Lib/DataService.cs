using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RadochinaAP.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double sum = 0;
            int count = 0;

            foreach (string line in lines)
            {
                string[] numbers = line.Split(' ');

                foreach (string numberStr in numbers)
                {
                    if (!string.IsNullOrWhiteSpace(numberStr))
                    {
                        string normalizedNumber = numberStr.Replace(".", ",");

                        if (double.TryParse(normalizedNumber, out double number))
                        {
                            if (number >= -1.5 && number <= 1.5)
                            {
                                sum += number;
                                count++;
                            }
                        }
                    }
                }
            }
            if (count > 0)
            {
                double average = sum / count;
                return Math.Round(average, 3);
            }
            else
            {
                return 0;
            }
        }
    }
}
       