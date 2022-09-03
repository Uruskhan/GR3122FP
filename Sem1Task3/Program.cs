// ================================================================
// # 3 Напишите програму, которая будет выдавать название дня недели по заданному номеру 
// ================================================================
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Monday";
    dayOfWeek[1] = "Tuesday";
    dayOfWeek[2] = "Wednesday";
    dayOfWeek[3] = "Thursday";
    dayOfWeek[4] = "Friday";
    dayOfWeek[5] = "Saturday";
    dayOfWeek[6] = "Sunday";

    if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    {
        Console.WriteLine("There is now such day!");
    }
    else
    {

        Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);

    }
}