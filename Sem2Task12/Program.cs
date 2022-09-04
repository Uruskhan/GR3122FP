// Напишите программу, которая принимать на вход два числа и выводить, вляется ли второе число кратным первому
// если второе число не кратно первому, то программа выводит остаток от деления 

void Variant1()
{
    Console.WriteLine("Введите два числа (I)");
    string? inputLineA = Console.ReadLine();
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        int inputNumberB = int.Parse(inputLineB);

        if (inputNumberB % inputNumberA == 0)
        {
            Console.WriteLine("Второе число кратно первому");
        }
        else
        {
            Console.WriteLine("Остаток от деления второго числа на первое равен " + inputNumberB % inputNumberA);
        }
    }
}

Variant1();

void VariantKonstantin()
{
    Console.WriteLine("Введите два числа (II)");
    string? inputLineA = Console.ReadLine();
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        int inputNumberB = int.Parse(inputLineB);

        Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления второго числа на первое равен " + inputNumberB % inputNumberA));
    }
}

VariantKonstantin();

// ==============================================================================================
// структурированный вариант решения задачи

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
CalculateData();
PrintData();

// получаем два числа от пользователя
void ReadData()
{
    Console.WriteLine("Введите два числа (№3)");
    string? inputLineA = Console.ReadLine();
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        inputNumberA = int.Parse(inputLineA);
        inputNumberB = int.Parse(inputLineB);
    }
}

// определяем кратность чисел
void CalculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

// выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления второго числа на первое равен " + inputNumberB % inputNumberA);
    }
}