using System.Text.Json;

public class Dataset
{
    List<Product> products = new List<Product>();

    public static Dataset BuildExistingDataset(string Data)
    {
        Product product = JsonSerializer.Deserialize<Product>(Data);
        Dataset dataset = new Dataset();
        dataset.products.Add(product);
        return dataset;
    }
}

