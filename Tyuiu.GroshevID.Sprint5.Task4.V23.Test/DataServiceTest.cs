using Tyuiu.GroshevID.Sprint5.Task4.V23.Lib;

namespace Tyuiu.GroshevID.Sprint5.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"С:\DataSprint5\InPutDataFileTask4V23.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
