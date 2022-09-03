// # 8 Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int startNumber = 2;

    while (startNumber > 1 && startNumber<inputNumber)
    {
        
        if (startNumber % 2 == 0)
        {
            Console.WriteLine(startNumber + ", ");
        }
        startNumber = startNumber + 2;
    }
}