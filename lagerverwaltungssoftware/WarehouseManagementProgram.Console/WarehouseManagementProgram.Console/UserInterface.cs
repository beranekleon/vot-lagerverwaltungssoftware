public class UserInterface
{
    private static Dictionary<string, (string featureName, Action action)> menuActions = new Dictionary<string, (string featureName, Action)>
    {
        {"1", ("Placeholder", () => PlaceholderFeature())},
        {"2", ("Placeholder", () => PlaceholderFeature())},
        {"q", ("end Program", () => EndProgram())}
    };

    #region internal methods
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
        //logic to end program (serialize all data)
        Console.WriteLine("Shutting down...");
        Environment.Exit(0);
    }

    #endregion

    #region external methods
    public static Dataset MountDataSet()
    {
        //this method reads the data for the program
        //firstly the user will we prompted to provide/mount a dataset
        Dataset dataset;
        Console.Write("Mount an existing Dataset? (y/n)");
        switch (Console.ReadLine())
        {
            case "y":
                //prompt for path to existing dataset
                Console.Write("\n Provide path to existing Dataset: ");
                string file_path = Console.ReadLine();
                dataset = Dataset.BuildExistingDataset(File.ReadAllText(file_path));
                break;
            case "n":
                //if no dataset is provided, a new dataset will be created
                //create new dataset
                dataset = new Dataset();
                break;
        }
        return dataset;
    }

    public static void PrintDataset(Dataset dataset)
    {
        throw new NotImplementedException();
    }

    #endregion
}

