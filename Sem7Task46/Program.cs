// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Gen2DArray(int rows, int columns, int minValue, int maxValue) // генерируем массив
{
    System.Random rand = new System.Random(); // 
    int[,] array2D = new int[rows, columns]; // выделяем память для нового массива с заданной длиной 

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = rand.Next(minValue, maxValue); // заполняем массив случайными числами
        }
    }
    return array2D; // возвращаем массив
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

void Print2DArrayColored(int[,] array) // принимает на вход массив и выводит на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rowsN = ReadData("Введите количество строк: ");
int columnsN = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(rowsN, columnsN, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
Print2DArrayColored(arr2D);