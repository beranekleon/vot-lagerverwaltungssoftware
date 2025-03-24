using System.Text.Json.Serialization;

public class Product
{
    public string Name { get; set; }

    //[JsonIgnore] --> can be used to ignore a property
    public int Price { get; set; }
}

