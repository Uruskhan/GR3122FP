// ================================================================
// # 2 Напишите програму, которая на вход принимает 2 числа 
// и выдаёт, какое число большее, а какое меньшее
// ================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine(inputNumberA);
    }
    else
    {
        if (inputNumberB > inputNumberA)
        {
            Console.WriteLine(inputNumberB);
        }
        else
        {
            Console.WriteLine("Digits are equal");
        }
    }
}