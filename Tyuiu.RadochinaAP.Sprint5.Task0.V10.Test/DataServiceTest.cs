using System.IO;
using Tyuiu.RadochinaAP.Sprint5.Task0.V10.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.RadochinaAP.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Кошка\source\repos\Tyuiu.RadochinaAP.Sprint5\Tyuiu.RadochinaAP.Sprint5.Task0.V10\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}

    