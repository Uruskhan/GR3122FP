// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

void MinArrayFinder(int[,] array, ref int x, ref int y)
{
    int min = array[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j]) min = array[i, j];
            x = i;
            y = j;
        }
    }
}

int[,] ChangedArray(int[,] array, int x, int y) // принимает на вход массив и выводит на экран
{
    int n = 0; int m = 0;
    int[,] outArr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == x)
        {
        }
        else
        {
            m = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == y)
                {
                }
                else
                {
                    outArr[n, m] = array[i, j];
                    m++;
                }
            }
            n++;
        }
    }
    return outArr;
}

int rowsN = ReadData("Введите количество строк: ");
int columnsN = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(rowsN, columnsN, 1, 20);
Print2DArray(arr2D);
Console.WriteLine();

int x = -1;
int y = -1;
MinArrayFinder(arr2D, ref x, ref y);
int[,] outArr = ChangedArray(arr2D, x, y);
Print2DArray(outArr);