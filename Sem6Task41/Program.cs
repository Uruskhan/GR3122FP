// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// // пользователь.
// // * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// // выдает сколько чисел больше 0 было введено.

double ReadData(string line)
{
    Console.Write(line);
    //Считываем число и преобразуем из строки в double
    double number = double.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int CountPosNumb(double num)
{
    int result = 0;
    for (int i = 0; i < num; i++)
    {
        double numbEnt = ReadData("Введите число: ");
        if (numbEnt > 0) result++;
    }
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

Console.WriteLine("Введите количество чисел для анализа: ");
double num = ReadData("");
PrintResult("Количество положительных чисел: " + CountPosNumb(num));