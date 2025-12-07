using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GroshevID.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.GetTempPath();
            pathSaveFile = Path.Combine(pathSaveFile, "InPutDataFileTask7V30.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);

            string strLine = "";
            using ( StreamReader reader = new StreamReader(path) )
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for ( int i = 0; i < line.Length; i++ )
                    {
                        char currentChar = line[i];

                        if (char.IsDigit(currentChar))
                        {
                            int start = i;
                            while (i < line.Length && char.IsDigit(line[i]))
                            {
                                i++;
                            }
                            i--;

                            bool isSingleDigit = (i - start == 0);

                            bool hasWordBoundaryBefore = (start == 0) || !char.IsLetterOrDigit(line[start - 1]);
                            bool hasWordBoundaryAfter = (i == line.Length - 1) || !char.IsLetterOrDigit(line[i + 1]);

                            if (isSingleDigit && hasWordBoundaryBefore && hasWordBoundaryAfter)
                            {
                                strLine.Append('9');
                            }
                            else
                            {
                                for (int j = start; j <= i; j++)
                                {
                                    strLine.Append(line[j]);
                                }
                            }
                        }
                        else
                        {
                            strLine.Append(currentChar);
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine.ToString() + Environment.NewLine);
                    strLine = "";
                }
            }

            return pathSaveFile;
        }
    }
}
