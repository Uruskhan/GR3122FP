

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

string BinConvert(int a)
{
    string result = string.Empty;
    while (a > 0)
    {
        result = a % 2 + result;
        a = a / 2;
    }
    return result;
}

int num10Form = ReadData("Введите число в десятичном формате: ");

PrintResult("Исходное число в бинарном формате: ", BinConvert(num10Form));

string num2Form = Convert.ToString(num10Form, 2);
PrintResult("Исходное число в бинарном формате встроенными средствами: ", num2Form);

string num8Form = Convert.ToString(num10Form, 8);
PrintResult("Исходное число в восьмеричном формате встроенными средствами: ", num8Form);

string num16Form = Convert.ToString(num10Form, 16);
PrintResult("Исходное число в шестнадцатиричном формате встроенными средствами: ", num16Form);
