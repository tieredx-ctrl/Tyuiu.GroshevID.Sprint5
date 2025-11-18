using Tyuiu.GroshevID.Sprint5.Task1.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = 5;

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
        Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до   *");
        Console.WriteLine("* трёх знаков после запятой.                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.ReadKey();
    }
}