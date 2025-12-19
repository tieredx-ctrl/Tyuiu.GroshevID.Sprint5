using Tyuiu.GroshevID.Sprint5.Task7.V30.Lib;

namespace Tyuiu.GroshevID.Sprint5.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V30.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
