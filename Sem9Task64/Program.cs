// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

string LineGenRec(int numN)
{
    if (numN == 0) return ""; //точка остановки
    string outline = numN + " " + LineGenRec(numN - 1);
    return outline;
}

int numB = ReadData("Введите число: ");
string resultLine = LineGenRec(numB);
PrintResult(resultLine);