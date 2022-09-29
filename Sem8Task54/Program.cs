//  Задайте двумерный массив. Напишите программу, которая 
//  упорядочит по убыванию элементы каждой строки двумерного массива.

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

// Получение строки из массива.
int[] GetRowFromArr(int[,] array, int i)
{
    int[] rowArr = new int[array.GetLength(1)];
    for (int j = 0; j < rowArr.Length; j++)
    {
        rowArr[j] = array[i, j];
    }
    return rowArr;
}

// Заменяет строку в массиве.
int[,] ChangeRowInArr(int[,] array, int i, int[] rowArr)
{
    for (int j = 0; j < rowArr.Length; j++)
    {
        array[i, j] = rowArr[j];
    }
    return array;
}

// Сортируем одномерный массив методом подсчета.
int[] ArraySortByCount(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }

    int[] count = new int[max - min + 1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] - min]++;
    }

    int j = 0;
    for (int i = max; i >= min; i--)
    {
        while (count[i - min]-- > 0)
        {
            array[j] = i;
            j++;
        }
    }
    return array;
}

// Сортировка 2D массива.
int[,] Sort2DArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        ChangeRowInArr(array, i, ArraySortByCount(GetRowFromArr(array, i)));
    }
    return array;
}

int[,] arr = Gen2DArray(4, 4, 1, 9);
PrintResult("Исходный массив: ");
Print2DArray(arr);
PrintResult("Сортированный массив: ");
Print2DArray(Sort2DArr(arr));