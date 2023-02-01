// Умножение матриц

using static System.Console;

WriteLine("Введите размерность матриц, минимальное и максимальное значение их элементов через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrixFirst = GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);
int[,] matrixSecond = GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrixFirst);
WriteLine();
PrintMatrixArray(matrixSecond);
WriteLine();
int[,] matrixMult = MultiMatrix(matrixFirst, matrixSecond);
WriteLine("Произведение матриц: ");
PrintMatrixArray(matrixMult);

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
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

int[,] MultiMatrix(int[,] inArrayFirst, int[,] inArraySecond)
{
    int[,] newMatrix = new int[inArrayFirst.GetLength(0), inArrayFirst.GetLength(1)];
    for (int i = 0; i < inArrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < inArrayFirst.GetLength(1); j++)
        {
            for (int k = 0; k < inArraySecond.GetLength(0); k++)
            {
                newMatrix[i,j] += inArrayFirst[i,k] * inArraySecond[k,j];
            }
        }
    }
    return newMatrix;
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