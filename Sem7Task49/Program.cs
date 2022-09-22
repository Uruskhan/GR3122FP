// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.

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

int[,] Change2DArray(int[,] oldArr2D)
{
    for (int i = 0; i < oldArr2D.GetLength(0); i += 2)
    {
        for (int j = 0; j < oldArr2D.GetLength(1); j += 2)
        {
            if (i % 2 == 0 && j % 2 == 0) oldArr2D[i, j] = oldArr2D[i, j] * oldArr2D[i, j];
        }
    }
    return oldArr2D;
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

int[,] matrix = Gen2DArray(m, n, 1, 9);
Console.WriteLine("Исходный массив: ");
Print2DArray(matrix);

Console.WriteLine("Измененный массив: ");
int[,] matrix2 = Change2DArray(matrix);
Print2DArray(matrix2);