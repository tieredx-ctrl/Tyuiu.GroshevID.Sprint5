using tyuiu.cources.programming.interfaces.Sprint5;

using System.Text;

namespace Tyuiu.GroshevID.Sprint5.Task3.V29.Lib
{
    public class DataService : ISprint5Task3V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempPath();
            path = Path.Combine(path, "OutPutFileTask3.bin");

            double f = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * (double)x + 4;
            f = Math.Round(f, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(f));
            }

            return path;
        }
    }
}
