using System.IO;
using Tyuiu.RadochinaAP.Sprint5.Task7.V23.Lib;
namespace Tyuiu.RadochinaAP.Sprint5.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V23.txt";

            var res = ds.LoadDataAndSave(path);
            FileInfo fileInfo = new FileInfo(res);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V23.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}