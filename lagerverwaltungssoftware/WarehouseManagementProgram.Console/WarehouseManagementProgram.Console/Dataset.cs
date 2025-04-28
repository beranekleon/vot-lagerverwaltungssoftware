using System.Text.Json;

public class Dataset
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void Print()
    {
        foreach (Product product in Products)
        {
            Console.WriteLine(product.ToString());
        }
    }
}
