// Упорядочить по убыванию элементы каждой строки двумерного массива

using static System.Console;

WriteLine("Введите размер двумерного массива, минимальное и максимальное значение через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(array);
WriteLine();
SortArray(array);
PrintMatrixArray(array);

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

void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - j - 1; k++)
            {
                if (inArray[i,k+1] > inArray[i, k])
                {
                int tmp = inArray[i,k+1];
                inArray[i,k+1] = inArray[i,k];
                inArray[i,k] = tmp;  
                }
            }
        } 
    }

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