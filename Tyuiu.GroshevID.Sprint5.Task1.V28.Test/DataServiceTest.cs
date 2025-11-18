using Tyuiu.GroshevID.Sprint5.Task1.V28.Lib;

namespace Tyuiu.GroshevID.Sprint5.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Дмитрий\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
