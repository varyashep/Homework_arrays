using static System.Console;

WriteLine("Введите размерность матрицы, минимальное и максимальное значение её элементов через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), double.Parse(parameters[2]), double.Parse(parameters[3]));
PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] resultMatrixArray = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrixArray[i,j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return resultMatrixArray;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j].ToString("F2")} ");
        }
        WriteLine();
    }
}