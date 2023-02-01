// Найти строку с минимальной суммой элементов

using static System.Console;

WriteLine("Введите размерность прямоугольного массива, минимальное и максимальное значение элемента через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(array);
int minRow = FindMinSum(array);
WriteLine($"Номер строки с минимальной суммой элементов: {minRow}");

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultArray = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return resultArray;
}

int FindMinSum(int[,] inArray)
{
    int[] sums = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sums[i] += inArray[i,j];
        }
    }
    int minSum = sums[0];
    int rowNumber = 1;
    for (int i = 0; i < sums.Length; i++)
    {
        if (sums[i] < minSum)
        {
            minSum = sums[i];
            rowNumber = i + 1;
        }
    }
    return rowNumber;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],3} ");
        }
        WriteLine();
    }
}