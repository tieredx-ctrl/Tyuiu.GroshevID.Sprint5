using System.IO;

using Tyuiu.GroshevID.Sprint5.Task0.V30.Lib;

namespace Tyuiu.GroshevID.Sprint5.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Дмитрий\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
