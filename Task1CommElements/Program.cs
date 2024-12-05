// See https://aka.ms/new-console-template for more information

string [] list1 = Console.ReadLine().Split(' ');
string [] list2 = Console.ReadLine().Split(' ');

var listCommon = list1.Intersect(list2).ToArray();
foreach (string s in listCommon) Console.WriteLine(s);
