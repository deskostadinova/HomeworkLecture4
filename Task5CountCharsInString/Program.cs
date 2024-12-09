// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a word or a sentence: ");
string inputChars = Console.ReadLine();

Dictionary<char, int> charCounts = new Dictionary<char, int>();

foreach (char c in inputChars)
{
    if (c != ' ') 
    {
        if (charCounts.ContainsKey(c))
        {
            charCounts[c]++;
        }
        else
        {
            charCounts[c] = 1;
        }
    }
}

foreach (var entry in charCounts)
{
    Console.WriteLine($"{entry.Key} -> {entry.Value}");
}
