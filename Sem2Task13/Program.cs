// 13 Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

void Variant1()
{
    Console.WriteLine("Введите число");
    string? inputLine = Console.ReadLine();

    if (inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);

        char[] charArray = inputNumber.ToString().ToCharArray();
        Console.WriteLine((charArray.Length > 2) ? charArray[2] : "в числе нет третьей цифры");
    }
}
Variant1();
