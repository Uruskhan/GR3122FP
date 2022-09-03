// ================================================================
// # 1 Напишите програму, которая на вход принимает 2 числа 
// и проверяет, не является ли одно квадратом второго
// ================================================================
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null&&inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    
    // bool outResult = (inputNumberA*inputNumberA == inputNumberB);
    // bool outResult = (inputNumberB/inputNumberA == inputNumberA);
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA);

    
    Console.WriteLine(outResult);
}
