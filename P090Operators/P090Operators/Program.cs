// See https://aka.ms/new-console-template for more information


Console.WriteLine("Give me a number of seconds");
int userInput = Convert.ToInt32(Console.ReadLine());

int secondsInADay = 60 * 60 * 24;
int secondsInAnHour = 60 * 60;
int secondsInAMinute = 60;

float totalInDays = (float)userInput / secondsInADay;

int days = GetDays();
int hours = GetHours();
int minutes = GetMinutes();
int seconds = GetSeconds();

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");
Console.WriteLine($"{days}:{hours}:{minutes}:{seconds}");
Console.WriteLine($"In total that's {totalInDays} days.");

int GetDays()
{
    return userInput / secondsInADay;
}

int GetHours()
{
    return (userInput % secondsInADay) / secondsInAnHour;
}

int GetMinutes()
{
    return (userInput % secondsInAnHour) / secondsInAMinute;
}

int GetSeconds()
{
    return (userInput % secondsInAMinute);
}