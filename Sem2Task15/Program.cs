// 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void Variant1()
{
    Console.WriteLine("Введите число от 1 до 7");
    string? inputLine = Console.ReadLine();

    if (inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);
        Console.WriteLine((inputNumber > 5 && inputNumber < 8) ? "этот день - выходной" : "это не выходной день");
    }
}
Variant1();