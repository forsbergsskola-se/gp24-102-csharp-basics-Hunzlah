// See https://aka.ms/new-console-template for more information

int maxTries = 10;
int guessCounter = 0;
bool gameWon = false;
int randInt = new Random().Next(1,101);
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

AskForInput:;

if (guessCounter >= maxTries)
{
    goto GameOver;
}

int number = Convert.ToInt32(Console.ReadLine());
guessCounter++;
if (number == randInt)
{
    gameWon = true;
}
else if (number < randInt)
{
    Console.WriteLine("Nope! My number is Greater!");
    goto AskForInput;
}
else
{
    Console.WriteLine("Nope! My number is Smaller!");
    goto AskForInput;
}

GameOver: ;
string finalMessage = gameWon ? ($"That's the number! Well played! You took {guessCounter} tries."): 
    ($"You lost the game! You've exceeded allowed attempts: {maxTries}");

Console.WriteLine(finalMessage);

