internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        List<string> items = new List<string>();

        Console.WriteLine("Enter items (enter 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
                break;

            items.Add(input);
        }
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Items in the list:\n");
        Console.WriteLine("Item\t\tQuantity");
        Console.WriteLine("----------------------------------------------------");

        foreach (string item in items)
        {
            Console.WriteLine($"{item}\t\t1");
        }
        Console.ReadKey();
    }
}