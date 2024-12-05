
int[] userInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
int counter = 1;
int max = 0;
int sequence = 0;
for (int i = 0 ; i < userInput.Length - 1; i++)
{
    if (userInput[i] == userInput[i + 1])
    {
        counter++;                   
    }
    else
    {                  
        counter = 1;                   
    }
    if (counter > max)
    {
        max = counter;
        sequence = userInput[i];
    }             
}
for (int j = 1; j <= max; j++)
{
    Console.Write($"{sequence} ");
}
