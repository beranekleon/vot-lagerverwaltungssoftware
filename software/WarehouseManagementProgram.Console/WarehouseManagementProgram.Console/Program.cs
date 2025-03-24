using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product { Name = "Laptop", Price = 1000 },
            new Product { Name = "Mouse", Price = 20 },
            new Product { Name = "Keyboard", Price = 50 }
        };

        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(products,options);

        string filePath = "products.json";
        File.WriteAllText(filePath, json);
        Console.WriteLine("JSON saved to:" + Path.GetFullPath(filePath));
    }
}

