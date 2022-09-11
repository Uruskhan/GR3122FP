// Написать программу которая принимает на вход координаты двух точек в трехмерном пространстве
// и находит между двумя этими точками расстояние

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double distanceFinder(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите координату Х первой точки: ");
int y1 = ReadData("Введите координату Y первой точки: ");
int z1 = ReadData("Введите координату Z первой точки: ");
int x2 = ReadData("Введите координату Х второй точки: ");
int y2 = ReadData("Введите координату Y второй точки: ");
int z2 = ReadData("Введите координату Z второй точки: ");

double res = distanceFinder(x1, y1, z1, x2, y2, z2);
PrintResult("Расстояние между точками равно: " + res);