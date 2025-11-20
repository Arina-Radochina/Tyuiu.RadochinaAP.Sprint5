using Tyuiu.RadochinaAP.Sprint5.Task0.V10.Lib;
namespace Tyuiu.RadochinaAP.Sprint5.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Пользователи\Кошка\source\repos\Tyuiu.RadochinaAP.Sprint5\Tyuiu.RadochinaAP.Sprint5.Task0.V10\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
