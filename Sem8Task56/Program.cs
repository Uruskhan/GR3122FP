// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

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

// Печать строки.
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Печать 2D массива.
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

int RowSumFinder(int[,] array2D) // принимает на вход двухмерный массив и создает массив сумм строк
{
    int[] sumOfRow = new int[array2D.GetLength(0)];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sumOfRow[i] = sumOfRow[i] + array2D[i, j];
        }
    }
    int min = sumOfRow[0];
    int minIndex = 0;
    for (int k = 0; k < sumOfRow.Length; k++)
    {
        if (sumOfRow[k] < min) min = sumOfRow[k]; minIndex = k;
    }
    return minIndex+1;
}


int[,] arr = Gen2DArray(5, 5, 0, 10);
Print2DArray(arr);
Console.WriteLine();
PrintResult("Минимальная сумма элементов строки исходного массива в строке: " + RowSumFinder(arr));
