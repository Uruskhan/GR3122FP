// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double CalculateData(int numA, int numB)
{
    double result = Math.Pow(numA, numB);
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

DateTime d1 = DateTime.Now;
CalculateData(numberA, numberB);
Console.WriteLine("Времени на обработку данных затрачено: " + (DateTime.Now - d1));

double res = CalculateData(numberA, numberB);

PrintResult("Число " + numberA + " в степени " + numberB + " равно " + res);