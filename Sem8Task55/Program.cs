// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

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
    double[,] newArray = new double[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
}

int rowsN = ReadData("Введите количество строк: ");
int columnsN = ReadData("Введите количество столбцов: ");
double[,] arr2D = Gen2DArray(rowsN, columnsN, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();

Print2DArray(ChangeArray(arr2D));