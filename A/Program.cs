int[] values = { 14, 0, 23, 0, -10, 25, 17, 17, 15, 6, 24, -1, -5, -7, 24, 8, 21, 4, 1, 5 };

foreach (int value in values)
{
    if (value % 3 == 0)
    {
        Console.WriteLine(value);
    }
}