// Напишите программу, которая принимать на вход число 
// и проверяет кратно ли это число одновременно 7 и 23 

void Variant1()
{
    Console.WriteLine("Введите число (I)");
    string? inputLineA = Console.ReadLine();

    if (inputLineA != null)
    {
        int inputNumberA = int.Parse(inputLineA);

        bool firstBV = (inputNumberA % 7 == 0);
        bool secondBV = (inputNumberA % 23 == 0);

        if (firstBV && secondBV)
        {
            Console.WriteLine("Число кратно 7 и 23");
        }
        else
        {
            Console.WriteLine("Число некратно одновременно 7 и 23");
        }
    }
}

Variant1();

void Variant2()
{
    Console.WriteLine("Введите число (II)");
    string? inputLineA = Console.ReadLine();

    if (inputLineA != null)
    {
        Console.WriteLine((int.Parse(inputLineA) % 161 == 0) ? ("Число кратно 7 и 23") : ("Число некратно одновременно 7 и 23"));
    }
}
Variant2();