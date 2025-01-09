// See https://aka.ms/new-console-template for more information

Dictionary<string, long> resources = new Dictionary<string, long>();

string command;
int commandCounter = 1;

while ((command = Console.ReadLine()) != "stop")
{
    if (commandCounter % 2 != 0)
    {
        string typeOfResource = command;
        long quantityOfResources = long.Parse(Console.ReadLine());

        if (resources.ContainsKey(typeOfResource))
        {
            resources[typeOfResource] += quantityOfResources;
        }
        else
        {
            resources[typeOfResource] = quantityOfResources;
        }
    }

    commandCounter+= 2;
}

foreach (var element in resources)
{
    Console.WriteLine($"{element.Key} -> {element.Value}");
}
    