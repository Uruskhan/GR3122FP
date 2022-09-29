// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


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

// Произведение Матриц.
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    return result;
}

int[,] arrA = Gen2DArray(4, 2, 1, 10);
int[,] arrB = Gen2DArray(2, 3, 1, 10);
PrintResult("Матрица А: ");
Print2DArray(arrA);
PrintResult("Матрица B: ");
Print2DArray(arrB);
PrintResult("Произведение матриц AxB: ");
Print2DArray(MatrixMultiplication(arrA, arrB));