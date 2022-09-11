// Напишите программу, которая принимать на вход 2 числа 
// и проверяет, является ли одно из них квадратом другого



int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int firstNum, int secondNum)
{
    if (SqrTest(firstNum, secondNum))
    {
        Console.WriteLine("Число " + firstNum + " является квадратом числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + firstNum + " не является квадратом числа " + secondNum);

    }
}

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");

PrintData(num1, num2);
PrintData(num2, num1);