﻿public class UserInterface
{
    private static Dictionary<string, (string featureName, Action action)> menuActions = new Dictionary<string, (string featureName, Action)>
    {
        {"1", ("Placeholder", () => PlaceholderFeature())},
        {"2", ("Placeholder", () => PlaceholderFeature())},
        {"q", ("end Program", () => EndProgram())}
    };

    public void AppControl(string[] args)
    {
        //check if program was started with data in args[]
        if (args.Length == 0)
        {

        }
    }

    private void PrintActionsMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press...");
            foreach (var keyValuePair in menuActions)
            {
                Console.WriteLine($"{keyValuePair.Key} for {keyValuePair.Value.featureName}");
            }
            Console.Write("Input: ");
            var input = Console.ReadLine();

            if (menuActions.TryGetValue(input, out var action))
            {
                Console.Clear();
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
    private static void PlaceholderFeature()
    {
        Console.WriteLine("Placholder...");
    }

    private static void EndProgram()
    {
        //logic to end program (i.e. serialize all data)
        Console.WriteLine("Shutting down...");
        Environment.Exit(0);
    }
}

