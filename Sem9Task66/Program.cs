// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

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

int RecSumDig(int num)
{
    if (num == 0) return 0; //точка остановки
    int sumOfDig = num + RecSumDig(num - 1);
    return sumOfDig;
}

int DiffFinder(int numN, int numM, int sumOfDigN, int sumOfDigM)
{
    if (numN >= numM) return sumOfDigN - sumOfDigM + numM;
    else return sumOfDigM - sumOfDigN + numN;
}

int numA = ReadData("ВВедите число N: ");
int numB = ReadData("ВВедите число M: ");

int resultLine = DiffFinder(numA, numB, RecSumDig(numA), RecSumDig(numB));
PrintResult("Сумма чисел в промежутке от M до N: " + resultLine);