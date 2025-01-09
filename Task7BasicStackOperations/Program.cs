int[] inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = inputParams[0]; 
int s = inputParams[1]; 
int x = inputParams[2]; 

int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    stack.Push(elements[i]);
}

for (int i = 0; i < s && stack.Count > 0; i++)
{
    stack.Pop();
}

if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Count > 0 ? stack.Min() : 0);
}