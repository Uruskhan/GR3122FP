// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

double ReadData(string line)
{
    Console.WriteLine(line);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[] LineCrossFinder(double numk1, double numb1, double numk2, double numb2)
{
    double x = (numb1 - numb2) / (numk2 - numk1);
    double y = numk1 * x + numb1;
    double[] result = new double[2] {x,y};
    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}

// void PrintResult(double line)
// {
//     Console.WriteLine(line);
// }

double num1 = ReadData("Задайте коэффициент k1 для первой прямой: ");
double num2 = ReadData("Задайте значение b1 для первой прямой: ");
double num3 = ReadData("Задайте коэффициент k2 для второй прямой: ");
double num4 = ReadData("Задайте значение b2 для второй прямой: ");

double[] crossFinder = LineCrossFinder(num1, num2, num3, num4);
PrintArray(crossFinder);
