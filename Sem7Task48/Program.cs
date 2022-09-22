// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArrayMN(int rows, int columns)
{
    int[,] arr2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = i + j;
        }
    }
    return arr2D;
}

void Print2DArray(int[,] array) // принимает на вход массив и выводит на экран
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

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");

int[,] matrix = Fill2DArrayMN(m, n);
Print2DArray(matrix);