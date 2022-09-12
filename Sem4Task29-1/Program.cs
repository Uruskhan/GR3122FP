// Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал 
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1). 

// сначала написал в виде программы без методов:

// string text = "Андрей,Богдан,Максим,Алексей,Павел";
// string[] textS = text.Split(",");
// Random rand = new Random();
// int i = rand.Next(0, textS.Length);
// Console.WriteLine(textS[i]);

string HelloUser(string line)
{
    Console.WriteLine(line);
    string text = Console.ReadLine() ?? " ";
    return text;
}

string[] ReadData(string line) 
{
    string[] array = line.Split(", ");
    return array;
}

string NameExtractor(string[] array)
{
    Random rand = new Random();
    int i = rand.Next(0, array.Length);
    return array[i];
}

void PrintName(string name)
{
    Console.WriteLine(name);
}

string listOfNames = HelloUser("Введите список имен через запятую");

string[] names = ReadData(listOfNames);

string arrayOfNames = NameExtractor(names); //"Андрей, Богдан, Максим, Алексей, Павел"

PrintName(arrayOfNames);

