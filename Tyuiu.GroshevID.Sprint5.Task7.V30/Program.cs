using Tyuiu.GroshevID.Sprint5.Task7.V30.Lib;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл ... (файл взять из архива согласно вашему варианту.            *");
        Console.WriteLine("* Создать папку в ручную ... и скопировать в неё файл) в котором есть     *");
        Console.WriteLine("* набор символьных данных. Заменить все однозначные числа на число 9.     *");
        Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V30.txt.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V30.txt");

        string tempDir = Path.GetTempPath();
        string pathSaveFile = Path.Combine(tempDir, "OutPutDataFileTask7V30.txt");

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Находится в файле: ");
        pathSaveFile = ds.LoadDataAndSave(path);

        Console.WriteLine(pathSaveFile);

        Console.ReadKey();
    }
}