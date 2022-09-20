// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины

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

bool TrnglTest(int a, int b, int c)
{
    bool res = false;
    if (a + b > c && c + b > a && a + c > b) res = true;
    return res;
}

int a = ReadData("Введите длину стороны A: ");
int b = ReadData("Введите длину стороны B: ");
int c = ReadData("Введите длину стороны C: ");

PrintResult (TrnglTest(a, b, c) ? "такой треугольник существует" : "такого треугольника не существует");