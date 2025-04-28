public class Product
{
    public int ItemID { get; set; }
    public string ItemName { get; set; }
    public int ItemStock { get; set; }
    public decimal ItemPrice { get; set; }
    public int ItemSales { get; set; }

    public Product(int ItemID, string ItemName, int ItemStock, decimal ItemPrice, int ItemSales)
    {
        this.ItemID = ItemID;
        this.ItemName = ItemName;
        this.ItemStock = ItemStock;
        this.ItemPrice = ItemPrice;
        this.ItemSales = ItemSales;
    }

    public override string ToString()
    {
        return $"ID: {ItemID} | Item Name: {ItemName} | Item Stock: {ItemStock} | Item Price: {ItemPrice} | Times sold: {ItemSales}x";
    }
}
