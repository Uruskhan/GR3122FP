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

// double[] LineCrossFinder(double numk1, double numb1, double numk2, double numb2)
// {

//     double x = (numb1 - numb2) / (numk2 - numk1);
//     double y = numk1 * x + numb1;
//     double[] result = new double[2] { x, y };
//     return result;
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1]);
//     Console.WriteLine();
// }

// прямая А --> y = k1 * x + b1,
// прямая B --> y = k2 * x + b2, 
// прямая C --> y = k3 * x + b3
double SquareFinder(double numk1, double numb1, double numk2, double numb2, double numk3, double numb3)
{
    // находим пересечение прямых А и В
    double x1 = (numb1 - numb2) / (numk2 - numk1);
    double y1 = numk1 * x1 + numb1;

    // находим пересечение прямых А и С
    double x2 = (numb1 - numb3) / (numk3 - numk1);
    double y2 = numk2 * x2 + numb2;

    // находим пересечение прямых С и В
    double x3 = (numb2 - numb3) / (numk3 - numk2);
    double y3 = numk3 * x3 + numb3;

    double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    double b = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
    double c = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
    double p = (a + b + c) / 2;

    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    return S;
}

void PrintResult(double line)
{
    Console.WriteLine(line);
}

double num1 = ReadData("Задайте коэффициент k1 для первой прямой: ");
double num2 = ReadData("Задайте значение b1 для первой прямой: ");
double num3 = ReadData("Задайте коэффициент k2 для второй прямой: ");
double num4 = ReadData("Задайте значение b2 для второй прямой: ");
double num5 = ReadData("Задайте коэффициент k3 для третьейпрямой: ");
double num6 = ReadData("Задайте значение b3 для третьей прямой: ");

double sqFinder = SquareFinder(num1, num2, num3, num4, num5, num6);
// PrintArray(crossFinder);
PrintResult(sqFinder);