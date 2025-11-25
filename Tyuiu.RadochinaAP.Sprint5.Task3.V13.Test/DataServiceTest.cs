using System.IO;
using Tyuiu.RadochinaAP.Sprint5.Task3.V13.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Tyuiu.RadochinaAP.Sprint5.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Кошка\source\repos\Tyuiu.RadochinaAP.Sprint5\Tyuiu.RadochinaAP.Sprint5.Task3.V13\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
     