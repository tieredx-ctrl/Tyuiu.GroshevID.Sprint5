int[,] array = { { -5, 7, -4 }, { 10, -12, -4 }, { 14, 8, 3 } };
int rowSum = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    rowSum += array[1, j];
}

Console.WriteLine(rowSum.ToString());