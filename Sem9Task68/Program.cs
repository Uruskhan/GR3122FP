// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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

int RecAccerman(int numN, int numM)
{
    int result = 0;
    if (numN == 0) result = numM + 1; //точка остановки
    if (numN > 0 && numM == 0) result = RecAccerman(numN - 1, 1);
    if (numN > 0 && numM > 0) result = RecAccerman(numN - 1, RecAccerman(numN, numM - 1));
    return result;
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");

int resultLine = RecAccerman(numA, numB);
PrintResult("Результат вычисления: " + resultLine);