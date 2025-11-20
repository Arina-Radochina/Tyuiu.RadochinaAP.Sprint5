using System.IO;
using Tyuiu.RadochinaAP.Sprint5.Task0.V10.Lib;
namespace Tyuiu.RadochinaAP.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Кошка\source\repos\Tyuiu.RadochinaAP.Sprint5\Tyuiu.RadochinaAP.Sprint5.Task0.V10\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(fileExists, wait);
        }
    }
}