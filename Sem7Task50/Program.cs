// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

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

bool FindNumInArray(int[,] array, int x, int y)
{
    return x >= 0 && y >= 0 && x < array.GetLength(0) && y < array.GetLength(1);
}

int rowsN = ReadData("Введите количество строк: ");
int columnsN = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(rowsN, columnsN, 10, 99);
Print2DArray(arr2D);

int x = ReadData("Введите номер строки: ");
int y = ReadData("Введите номер столбца: ");
Console.WriteLine("Элемент на указанной позиции: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(FindNumInArray(arr2D, x, y) ? arr2D[x, y] : "Задана отсутствующая позиция в массиве");