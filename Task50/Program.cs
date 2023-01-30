using static System.Console;


WriteLine("Введите размерность матрицы, минимальный и максимальный элемент через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries),int.Parse);
int[,] array = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(array);
WriteLine("Введите через пробел индекс элемента, который необходимо вывести: ");
int[] parameters2 =  Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries),int.Parse);
CheckElem(parameters2[0], parameters2[1], array);

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

void CheckElem(int m, int n, int[,] inArray)
{
    if (inArray.GetLength(0) >= m && inArray.GetLength(1) >= n)
    {
        WriteLine(inArray[m,n]);
    }
    else
    {
        WriteLine("Такого элемента нет в массиве");
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