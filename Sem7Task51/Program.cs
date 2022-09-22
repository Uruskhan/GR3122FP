// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Gen2DArray(int rows, int columns, int minValue, int maxValue) // генерируем двухмерный массив
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

int DiagonalSumFinder(int[,] arr2D)
{
    int sum = 0;
    int length = ((arr2D.GetLength(0) > arr2D.GetLength(1)) ? (arr2D.GetLength(1)) : (arr2D.GetLength(0)));
    for (int i = 0; i < length; i++)
    {
        sum = sum + arr2D[i, i];
    }
    return sum;
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

int sum2D = DiagonalSumFinder(matrix);
Console.WriteLine($"Сумма элементов массива по диагонали равна: {sum2D}");
