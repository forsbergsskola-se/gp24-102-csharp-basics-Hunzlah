// See https://aka.ms/new-console-template for more information
// https://github.com/forsbergsskola-se/gp24-102-csharp-basics-Hunzlah

bool isPlayerTurn = true;
int numberOfMatches = 24;

Console.WriteLine("Output: Welcome to Nim!");
DisplayRemainingMatches();
Console.WriteLine("Output: How many matches do you want to draw?");

while (numberOfMatches > 0)
{
    int playerInput;
    if (isPlayerTurn)
    {
        Console.Write("Input: ");
        playerInput = Convert.ToInt32(Console.ReadLine());

        if (playerInput < 1 || playerInput > 3)
        {
            Console.WriteLine("Invalid input.");
            continue;
        }
        else
        {
            isPlayerTurn = !isPlayerTurn;
        }
    }
    else
    {
        playerInput = new Random().Next(1,4);
        isPlayerTurn = !isPlayerTurn;
    }

    if (numberOfMatches - playerInput <= 0)
    {
        numberOfMatches = 0;

        string result = isPlayerTurn ? "AI drew the last match. You win." : "You drew the last match. You lose.";
        Console.WriteLine(result);
        break;
    }
    else
    {
        numberOfMatches -= playerInput;
        if (isPlayerTurn)
        {
            Console.WriteLine($"The AI draws {playerInput} matches.");
        }
        DisplayRemainingMatches();
    }
    
}


void DisplayRemainingMatches()
{
    Console.Write("Output: ");
    for (int i = 0; i < numberOfMatches; i++)
    {
        Console.Write("|");
    }
    Console.Write($" ({numberOfMatches}) \n");
}