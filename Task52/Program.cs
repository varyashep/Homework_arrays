using static System.Console;

WriteLine("Введите размерность матрицы, минимальный и максимальный элемент через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries),int.Parse);
int[,] array = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(array);
double[] resultAverage = countAverage(array);
Write("Среднее арифетическое значение каждого столбца: ");
PrintArray(resultAverage);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultArray = new int[rows, columns];
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

double[] countAverage(int[,] inArray)
{
    double[] average = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum += inArray[j,i];
        }
        average[i] = Convert.ToDouble(sum) / inArray.GetLength(0);
    }
    return average;
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

void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i].ToString("F2")}, ");
    }
    Write(inArray[inArray.Length-1].ToString("F2"));
}