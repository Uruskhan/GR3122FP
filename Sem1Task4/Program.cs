// ================================================================
// # 4 Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел
// ================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

Console.WriteLine (Math.Max(inputNumberA,Math.Max(inputNumberB,inputNumberC)));
    // //  вариант Голикова
    // int Max = inputNumberA;
    // if (inputNumberB > Max)
    // {
    //     Max = inputNumberB;
    // }
    // if (inputNumberC > Max)
    // {
    //     Max = inputNumberC;
    // }
    // // мой вариант
    // // int Max = 0;
    // // if (inputNumberA > inputNumberB)
    // // {
    // //     Max = inputNumberA;
    // //     if (inputNumberC > Max)
    // //     {
    // //         Max = inputNumberC;
    // //     }
    // // }
    // // else
    // // {
    // //     if (inputNumberB > inputNumberC)
    // //     {
    // //         Max = inputNumberB;
    // //     }
    // //     else
    // //     {
    // //         Max = inputNumberC;
    // //     }
    // // }
    // Console.WriteLine("Maximum of this digits is " + Max);
}