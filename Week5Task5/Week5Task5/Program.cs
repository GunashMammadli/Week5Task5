namespace Week5Task4;
internal class Program
{
    static void Main(string[] args)
    {
        CustomList<int> items = new CustomList<int>(10, 25, 38, 33, 87, 44, 33, 67, 65, 33);
        items.Add(1);
        items.Add(22);
        items.Add(63);
        items.Add(33);
        Console.WriteLine("Add");
        items.GetInfo();
        Console.WriteLine("Exist");
        Console.WriteLine(items.Exist(63));
        Console.WriteLine("Remove");
        items.Remove(1);
        items.GetInfo();
        Console.WriteLine("Reverse");
        items.Reverse();
        items.GetInfo();
        Console.WriteLine("First Index");
        Console.WriteLine(items.IndexOf(33));
        Console.WriteLine("Last Index");
        Console.WriteLine(items.LastIndexOf(33));
    }
}

