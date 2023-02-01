// Трехмерный массив из неповторяющихся двузначных чисел
using static System.Console;

WriteLine("Введите размер трехмерного массива через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,,] array = GetArray(parameters[0], parameters[1], parameters[2]);
PrintArray(array);

int[,,] GetArray(int length, int width, int height)
{
    Random rnd = new Random();
    int[,,] resultArray = new int[length, width, height];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                resultArray[i,j,k] = rnd.Next(10,100);
            }
        }
    }
    return resultArray;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i,j,k]} ({i},{j},{k}) ");
            }
        }
        WriteLine();
    }
}