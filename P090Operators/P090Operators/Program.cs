// See https://aka.ms/new-console-template for more information


Console.WriteLine("Output: Give me a number of seconds");
Console.Write("Input: ");
int userInput = Convert.ToInt32(Console.ReadLine());

int secondsInADay = 60 * 60 * 24;
int secondsInAnHour = 60 * 60;
int secondsInAMinute = 60;

float totalInDays = (float)userInput / secondsInADay;

int days = GetDays();
int hours = GetHours();
int minutes = GetMinutes();
int seconds = GetSeconds();

Console.WriteLine($"Output: Seconds: {seconds}");
Console.WriteLine($"Output: Minutes: {minutes}");
Console.WriteLine($"Output: Hours: {hours}");
Console.WriteLine($"Output: Days: {days}");
Console.WriteLine($"Output: {days}:{hours}:{minutes}:{seconds}");
Console.WriteLine($"Output: In total that's {totalInDays} days.");

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