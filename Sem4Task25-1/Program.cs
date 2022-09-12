// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double CalculateData(int numA, int numB, int numC) // калькулятор примитивный, работает только с двумя числами
{
    double result = 0;
    if (numC == 1) result = numA + numB;
    if (numC == 2) result = numA - numB;
    if (numC == 3) result = numA * numB;
    if (numC == 4) result = numA / numB;
    if (numC == 5) result = Math.Pow(numA, numB);
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");
int numberC = ReadData("Введите цифру от 1 до 5, обозначающую тип операции (1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление, 5 - возведение в степень): ");

DateTime d1 = DateTime.Now;
CalculateData(numberA, numberB, numberC);
Console.WriteLine("Времени на обработку данных затрачено: " + (DateTime.Now - d1));

double res = CalculateData(numberA, numberB, numberC);

PrintResult("Результат вычисления равен: " + res);