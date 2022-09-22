// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.

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
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

double[] ColumnSumFinder(int[,] array2D) // принимает на вход массив и сщздает массив
{
    double[] newArray = new double[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            newArray[j] = newArray[j] + array2D[i, j];
        }
    }

    return newArray;
}

double[] AvgSumFinder(double[] array, int N)
{
    double[] newArray = new double[array.Length];
    for (int k = 0; k < array.Length; k++)
    {
        newArray[k] = Math.Round(array[k] / N, 2);
    }
    return newArray;
}

void PrintArray(double[] array) // принимает на вход массив и выводит на экран
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}

void Print2DArrayDiffColor(int[,] array) // принимает на вход массив и раскрашивает его разеыми цветами
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i, j] = array[i, j];
            Console.Write($"{newArray[i, j]} \t");
        }
        Console.WriteLine();    
    }
}

int rowsN = ReadData("Введите количество строк: ");
int columnsN = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(rowsN, columnsN, 1, 9);

Print2DArray(arr2D);
double[] avgColumnSum = AvgSumFinder(ColumnSumFinder(arr2D), rowsN);
PrintArray(avgColumnSum);

Console.WriteLine();

Print2DArrayDiffColor(arr2D);