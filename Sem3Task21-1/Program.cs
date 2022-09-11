// Написать программу которая принимает на вход координаты двух точек в трехмерном пространстве
// в виде строки и находит между двумя этими точками расстояние
// НЕ РЕШЕНА!!!

int ReadData(string line) // перевожу в массив полученые в виде строки координаты
{
    Console.WriteLine(line);
    
    return array;
}

// double distanceFinder(int number)
// {
//     char[] arrayN = number.ToString().ToCharArray();
//     int x1 = arrayN[0];
//     int y1 = arrayN[1];
//     int z1 = arrayN[2];
//     int x2 = arrayN[3];
//     int y2 = arrayN[4];
//     int z2 = arrayN[5];
//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     return result;
// }

// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

ReadData("Введите координаты точек в формате А(x1,y1,z1);B(x2,y2,z2): ");

// double res = distanceFinder(coordinates);
// PrintResult("Расстояние между точками равно: " + res);