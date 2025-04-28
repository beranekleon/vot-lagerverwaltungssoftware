using System.Text.Json;

public class AppControl
{
    Dataset dataset;

    public void RunApp()
    {
        InitApp();

    }

    private void InitApp()
    {
        Console.WriteLine("Lagerverwaltungssoftware v0.1");
        Console.Write("Path to Dataset: ");
        string file_path = Console.ReadLine();
        if (file_path == "")
        {
            dataset = new Dataset();
        }
        else
        {
            string JsonFromFile = File.ReadAllText(file_path);
            dataset = JsonSerializer.Deserialize<Dataset>(JsonFromFile);
        }

        dataset.Print();
        UserInterface.PrintActionsMenu();
    }

}

