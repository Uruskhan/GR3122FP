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

int RecPow(int numA, int numB)
{
    if (numB == 1) return numA; //точка остановки
    int powNum = numA * RecPow(numA, numB - 1);
    return powNum;
}

int numA = ReadData("ВВедите число A: ");
int numB = ReadData("ВВедите число B: ");

int resultLine = RecPow(numA, numB);
PrintResult("Число A в степени B : " + resultLine);