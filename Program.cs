using Sem3HW;

LinkedList list = new LinkedList();

for (int i = 0; i < 10; i++)
{
    list.Add(new Random().Next(0,100));
}

list.Print();
System.Console.WriteLine();
System.Console.WriteLine();

list.Reverse();
list.Print();

list.Remove(int.Parse(Console.ReadLine()!));
list.Print();
