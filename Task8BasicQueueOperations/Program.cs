// See https://aka.ms/new-console-template for more information

int[] inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = inputParams[0]; 
int s = inputParams[1]; 
int x = inputParams[2]; 

int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>();

for (int i = 0; i < n; i++)
{
    queue.Enqueue(elements[i]);
}

for (int i = 0; i < s && queue.Count > 0; i++)
{
    queue.Dequeue();
}

if (queue.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Count > 0 ? queue.Min() : 0);
}