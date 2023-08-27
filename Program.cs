// Print backstory to user
Console.WriteLine("Welcome to the Factory!");
Console.WriteLine("You are a young factory worker of an oil company who has been working for years without break");
Console.WriteLine("Now that you have been working for years you have been promoted to manager role");
Console.WriteLine("The factory has 40 employees and you do not have any personal relationships with any of them");
Console.WriteLine("An employee approaches you named Sandra asking if she could talk to you in private");
Console.WriteLine("Would you like to talk to her in public or in private?");

// Prompt the user for a choice
Console.Write("> ");
string roomChoice = Console.ReadLine();

// Ask player where they want to talk
if(roomChoice == "Private")
{
    Console.WriteLine("You chose to talk in private");
    Console.WriteLine("As you walk in your office you smell Sandra begins to cry");
    Console.WriteLine("Do you want to comfort Sandra?");

    // Prompt the user for a choice
    Console.Write("> ");
    string SandracryingChoice = Console.ReadLine();

    if(SandracryingChoice == "yes")
    {
        Console.WriteLine("You attempt to comfort Sandra as she is crying, but she feels vulnerable and holds you");
        Console.WriteLine("You show the same affection being recieved");
    }
    else if(SandracryingChoice == "no")
    {
        Console.WriteLine("You decide not to comfort Sandra due to work regulations");
        Console.WriteLine("You tell Sandra to spit it out as you cannot help if she does not talk about it");
        Console.WriteLine("You fire Sandra and throw her stuff out the factory, you then get sued and fired from the company while Sandra lives off her entilment and becomes CEO");
        Console.WriteLine("You regret your decision and beg Sandra to forgive you, you spend years making it up to her and eventually marrying her");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please answer yes or no");
    }
}
else if(roomChoice == "public")
{
    Console.WriteLine("You chose to speak to Sandra in public knowing she asked to speak in private, terrible manager");
    Console.WriteLine("As Sandra explains her mother has passed and she cannot seem to be able to work you seem dissappointed");
    Console.WriteLine("Do you want to give her time off to grieve?");

    // Prompt the user for a choice
    Console.Write("> ");
    string timeoffChoice = Console.ReadLine();

    if (timeoffChoice == "yes")
    {
        Console.WriteLine("You give Sandra time off work to grieve her lost family member");
        Console.WriteLine("Sandra thanks you and packs up her stuff and signs off for the day");
    }
    else if (timeoffChoice == "no")
    {
        Console.WriteLine("You decide not to give Sandra time off because you're awful and want her to suffer");
        Console.WriteLine("Sandra slaps you and runs off crying while returning to her duties");
    }
    else 
    {
        Console.WriteLine("Invalid choice. Please answer yes or no");
    }
}
else
{
    Console.WriteLine("Invalid choice. Please answer private or public");
}