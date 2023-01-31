// Написать программу, которая обменивает элементы первой строки и последней строки

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
        }
    }
}

void ChangeStringsOfArray(int[,] array)
{
    int temp = 0;
    int i = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
            temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - 1, j];
            array[array.GetLength(0) - 1, j] = temp;
    }
}

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeStringsOfArray(array);
PrintArray(array);