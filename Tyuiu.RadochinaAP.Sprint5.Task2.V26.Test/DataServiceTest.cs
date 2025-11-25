using System.IO;
using Tyuiu.RadochinaAP.Sprint5.Task2.V26.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.RadochinaAP.Sprint5.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Кошка\source\repos\Tyuiu.RadochinaAP.Sprint5\Tyuiu.RadochinaAP.Sprint5.Task2.V26\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
       