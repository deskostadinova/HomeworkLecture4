// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the first player deck here: ");
List<int> firstPlayersDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
Console.WriteLine("Enter the second player deck here: ");
List<int> secondPlayersDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList(); 

bool areListsSameLenght = (new[] { firstPlayersDeck, secondPlayersDeck })
    .All(l => l.Count == firstPlayersDeck.Count);

if (areListsSameLenght)
{
    Queue<int> firstPlayer = new Queue<int>(firstPlayersDeck);
    Queue<int> secondPlayer = new Queue<int>(secondPlayersDeck);

    while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
    {
        int firstCard = firstPlayer.Dequeue();
        int secondCard = secondPlayer.Dequeue();

        if (firstCard > secondCard)
        {
            firstPlayer.Enqueue(firstCard);
            firstPlayer.Enqueue(secondCard);
        }
        else if (firstCard < secondCard)
        {
            secondPlayer.Enqueue(secondCard);
            secondPlayer.Enqueue(firstCard);
        }
        else if (firstCard == secondCard)
        {
            firstPlayer.Enqueue(firstCard);
            secondPlayer.Enqueue(secondCard);
        }
        else
        {
            break;
        }
    }

    if (firstPlayer.Count > 0)
    {
        int totalCount = firstPlayer.Sum();
        Console.WriteLine($"The first player wins with total of {totalCount}");
    }
    else
    {
        int totalCount = secondPlayer.Sum();
        Console.WriteLine($"The second player wins with total of {totalCount}");
    }
}

else
{
    Console.WriteLine("Both decks should contain the same number of cards.");
}




