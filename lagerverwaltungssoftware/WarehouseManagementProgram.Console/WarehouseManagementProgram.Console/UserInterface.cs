public class UserInterface
{
    private static Dictionary<string, (string featureName, Action action)> menuActions = new Dictionary<string, (string featureName, Action)>
    {
        {"1", ("Add Product", () => AddProduct())},
        {"2", ("Record sales", () => PlaceholderFeature())},
        {"3", ("Record goods receipt", () => PlaceholderFeature())},
        {"4", ("Placeholder", () => PlaceholderFeature())},
        {"q", ("end Program", () => EndProgram())}
    };
    
    public static void PrintActionsMenu()
    {
        while (true)
        { 
            Console.WriteLine("Press...");
            foreach (var keyValuePair in menuActions)
            {
                Console.WriteLine($"{keyValuePair.Key} for {keyValuePair.Value.featureName}");
            }
            Console.Write("Input: ");
            var input = Console.ReadLine();

            if (menuActions.TryGetValue(input, out var action))
            {
                action.action.Invoke();
                Console.WriteLine("Action complete, press any key.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input. Press any key to try again");
                Console.ReadKey();
            }
        }
    }

    private static void AddProduct()
    {
        Product product;
        Console.WriteLine("Specify new product information ('[ID, int] [Name, string] [Stock, int] [Price, decimal] [Sales, int]'): ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

    }

    private static void PlaceholderFeature()
    {
        Console.WriteLine("Placholder...");
    }

    private static void EndProgram()
    {
        //logic to end program (serialize all data)
        Console.WriteLine("Shutting down...");
        Environment.Exit(0);
    }
}

