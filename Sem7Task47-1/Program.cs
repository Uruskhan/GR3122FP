//------------------------------------Задача 47----------------------------------------------
//----Задайте двумерный массив размером m×n, заполненный случайными вещественными числами----
//-------------------------------------------------------------------------------------------

//Используем старые методы и немного их корректируем под заданную задачу
double[,] FillTwoDimDoubleArr(int countRow, int countColumn)
{
    double[,] outArray = new double[countRow, countColumn];
    System.Random numberSintezator = new System.Random();
    int i = 0;
    int j = 0;

    while(i < countRow)
    {
        j = 0;
        while(j < countColumn)
        {
            //Заполняем массив вещественными числами и округляем их до 2 знаков после запятой
            outArray[i, j] = numberSintezator.Next(-11, 11) + numberSintezator.NextDouble();
            outArray[i, j] = Math.Round(outArray[i, j], 2);
            j++;
        }
        i++;
    }
    return outArray;
}

//Массив всех цветов для цветного вывода в консоли
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, 
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, 
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, 
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, 
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, 
                                        ConsoleColor.Yellow};

//Метод по выводу разноцветных цифр для любых двумерных массивов, так же будет работать и со строками и одномерными массивами если немного исправить
void PrintColorDimArray(double[,] inputArray)
{
    int i = 0;
    int j = 0;

    while(i < inputArray.GetLength(0))
    {
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            //разбиваем число на символы
            char[] number = inputArray[i, j].ToString().ToCharArray();

            for(int k = 0; k < number.Length; k++)
            {
                //на каждый символ задаем свой цвет
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(number[k]);
                Console.ResetColor();
            }
            Console.Write(" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

double[,] twoDimArray = FillTwoDimDoubleArr(3, 4);
PrintColorDimArray(twoDimArray);