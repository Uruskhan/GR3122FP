// Генерация 2D массива.
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

// Возращает строку масива.
int[] GetRow(int[,] arr,int iRow)
{   
    int[] row = new int[arr.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[iRow,j];
    }
    return row;
}

int[,] arr = Gen2DArray(4,4,1,10);
PrintResult("Исходный массив: "); 
Print2DArray(arr);
GetRow(arr, 4);
Console.WriteLine();
Print2DArray(arr);