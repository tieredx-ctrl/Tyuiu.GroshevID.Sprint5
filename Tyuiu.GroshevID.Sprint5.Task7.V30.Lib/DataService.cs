using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GroshevID.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string tempDir = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempDir, "OutPutDataFileTask7V30.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);

            string text = File.ReadAllText(path);

            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    bool leftIsDigit = i > 0 && char.IsDigit(chars[i - 1]);
                    bool rightIsDigit = i < chars.Length - 1 && char.IsDigit(chars[i + 1]);

                    if (!leftIsDigit && !rightIsDigit)
                    {
                        chars[i] = '9';
                    }
                }
            }

            string result = new string(chars);
            File.WriteAllText(pathSaveFile, result);

            return pathSaveFile;
        }
    }
}
