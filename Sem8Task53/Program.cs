// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[,] Gen2DArray(int rows, int columns, double minValue, double maxValue) // генерируем массив
{
    System.Random rand = new System.Random(); // 
    double[,] array2D = new double[rows, columns]; // выделяем память для нового массива с заданной длиной 

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = Math.Round(rand.NextDouble() * 100, 2); // заполняем массив случайными числами
        }
    }
    return array2D; // возвращаем массив
}

void Print2DArray(double[,] array) // принимает на вход массив и выводит на экран
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

double[,] ChangeArray(double[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        newArray[i] = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = newArray[i];
    }
    return array;
}

int rowsN = ReadData("Введите количество строк: ");
int columnsN = ReadData("Введите количество столбцов: ");
double[,] arr2D = Gen2DArray(rowsN, columnsN, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
double[,] arr2DChanged = ChangeArray(arr2D);
Print2DArray(arr2DChanged);