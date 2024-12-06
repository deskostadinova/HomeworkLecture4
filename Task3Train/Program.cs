Console.WriteLine("Enter a list of numbers. Every separate number will represent a wagon with " +
                  "number of passengers. ");

List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

Console.WriteLine("Enter the maximum capacity of the wagon.");
int maxCapacity = int.Parse(Console.ReadLine());
int newPassengers = 0;

string command = null;

while (command!="end")
{
    Console.WriteLine("Enter a command add or end:");
    command = Console.ReadLine();
    if (command == "add")
    {
        Console.WriteLine("Add wagon: ");
        int newWagon = int.Parse(Console.ReadLine());
        wagons.Add(newWagon);
    
        Console.WriteLine("Add number of passengers: ");
        
        // Get number of passengers to be boarded
        newPassengers = int.Parse(Console.ReadLine());
        
        // Iterate through the wagons
        for (int i = 0; i < wagons.Count; i++)
        {
            // Get number of free seats for the current wagon
            int wagonSeatsRemaining = maxCapacity - wagons[i];
            
            // if free seats are less than the number of passengers, fill the wagon
            if (wagonSeatsRemaining <= newPassengers)
            {
                wagons[i] += wagonSeatsRemaining;
                newPassengers -= wagonSeatsRemaining; // deduct the number of remaining passengers
            }
            else
            {
                // fill the wagon with the leftover of remaining passengers and set the remaining passengers to 0
                wagons[i] += newPassengers;
                newPassengers = 0;
            }
        }
    } else  if  (command == "end")
    {
        // Print the final passenger count in each of the wagons
        Console.WriteLine("Final wagons: ");
        foreach (var wagon in wagons)
        {
            Console.Write(wagon + " ");
        }
        
        if (newPassengers > 0)
        {
            Console.WriteLine($"\n{newPassengers} not able to board the train");
        }
    }
    else
    {
        Console.WriteLine("Invalid command.");
    }
}
