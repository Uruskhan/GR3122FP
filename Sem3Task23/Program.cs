// написать программу которая на вход получает число N
// и на выходе выводит таблицу кубов всех чисел от единицы до N

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// 1 2 3 4  5  6
// 1 8 27 64 125 216

string lineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i <= numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t | ";
        ++i;
    }
    return outLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


int num = ReadData("Введите число: ");
string result = lineNumbers(num, 1);
string result2 = lineNumbers(num, 3);

PrintResult(result);
PrintResult(result2);

