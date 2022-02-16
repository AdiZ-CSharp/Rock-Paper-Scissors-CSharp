Random randIndex = new Random();

while (true)
{
    string[] choices = { "rock", "paper", "scissors" };

    string player = "";
    string computer = choices[randIndex.Next(choices.Length)];

    while (!choices.Contains(player))
    {
        Console.WriteLine("Rock, Paper, or Scissors?");
        player = Console.ReadLine().ToLower();
    }

    if (player == computer)
    {
        printResult(player, computer);
        Console.WriteLine("\nTie!");
    }
    else if (player == "rock")
    {
        printResult(player, computer);
        rock(computer);
    }
    else if (player == "paper")
    {
        printResult(player, computer);
        paper(computer);
    }
    else if (player == "scissors")
    {
        printResult(player, computer);
        scissors(computer);
    }

    if (!playAgain())
    {
        break;
    }
}

Console.ReadKey();

// Methods below this line


void printResult(string player, string computer)
{
    Console.WriteLine("\nYou played " + player);
    Console.WriteLine("The computer played " + computer);
}

void rock(string computer)
{
    if (computer == "paper")
    {
        Console.WriteLine("\nYou lose.");
    }
    else
    {
        Console.WriteLine("\nYou win!");
    }
}

void paper(string computer)
{
    if (computer == "rock")
    {
        Console.WriteLine("\nYou win!");
    }
    else
    {
        Console.WriteLine("\nYou lose.");
    }
}

void scissors(string computer)
{
    if (computer == "rock")
    {
        Console.WriteLine("\nYou lose.");
    }
    else
    {
        Console.WriteLine("\nYou win!");
    }
}

bool playAgain()
{
    string[] playAgainChoices = { "y", "yes", "n", "no" };
    string reply = "";

    while (!playAgainChoices.Contains(reply))
    {
        Console.WriteLine("\nPlay again? y/yes/n/no");
        reply = Console.ReadLine();
    }

    if (reply == "y" | reply == "yes")
    {
        return true;
    }
    else
    {
        return false;
    }
}