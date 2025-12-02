using Tyuiu.GroshevID.Sprint5.Task5.V10.Lib;

namespace Tyuiu.GroshevID.Sprint5.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"С:\DataSprint5\InPutDataFileTask5V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
