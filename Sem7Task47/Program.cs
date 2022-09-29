// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

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

// принимает на вход массив и выводит его на экран раскрашенным в один цвет
void Print2DArrayColored(double[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// принимает на вход массив и раскрашивает каждое число массива (!) разными цветами
void Print2DArrayDiffColor(double[,] array) // принимает на вход массив и раскрашивает его разеыми цветами
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write($"{array[i, j]} \t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// принимает на вход массив и раскрашивает каждую цифру (!) разными цветами
void Print2DArrayDiffColor2(double[,] array) 
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            char[] number = array[i, j].ToString().ToCharArray();
            for(int k = 0; k < number.Length; k++)
            {
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(number[k]);
                Console.ResetColor();
            }
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

int rowsN = ReadData("Введите количество строк: ");
int columnsN = ReadData("Введите количество столбцов: ");
double[,] arr2D = Gen2DArray(rowsN, columnsN, 10, 99);
Print2DArray(arr2D);

Console.WriteLine();
Print2DArrayColored(arr2D);

Console.WriteLine();
Print2DArrayDiffColor(arr2D);

Console.WriteLine();
Print2DArrayDiffColor2(arr2D);