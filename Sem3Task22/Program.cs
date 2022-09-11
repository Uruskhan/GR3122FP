// написать программу которая на вход получает число N
// и на выходе выводит

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// 1 2 3 4  5  6
// 1 4 9 16 25 36

string lineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN + 1)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    return outLine;
}

// string lineSquare(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN + 1)
//     {
//         outLine = outLine + i * i + "\t";
//         ++i;
//     }
//     return outLine;
// }

void PrintResult(string line)
{
    Console.WriteLine(line);
}


int num = ReadData("Введите число: ");
string result = lineNumbers(num, 1);
string result2 = lineNumbers(num, 2);

PrintResult(result);
PrintResult(result2);

