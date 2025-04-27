using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        //Product[] products = new Product[]
        //{
        //    new Product { Name = "Laptop", Price = 1000 },
        //    new Product { Name = "Mouse", Price = 20 },
        //    new Product { Name = "Keyboard", Price = 50 }
        //};

        //var options = new JsonSerializerOptions { WriteIndented = true };
        //string json = JsonSerializer.Serialize(products,options);

        //string filePath = "products.json";
        //File.WriteAllText(filePath, json);
        //Console.WriteLine("JSON saved to:" + Path.GetFullPath(filePath));

        //Product[] products = new Product[]
        //{
        //    new Product { ItemName = "Laptop", ItemPrice = 1000 },
        //    new Product { ItemNumber = 2, ItemStock = 20 }
        //};

        //var options = new JsonSerializerOptions { WriteIndented = true };
        //string json = JsonSerializer.Serialize(products, options);

        //string filePath = "products.json";
        //File.WriteAllText(filePath, json);

        //testeshalber werde ich mal alles implementieren was man zu 100% braucht wenn man das programm
        //startet/schließt. dazu gehört
        // -> die daten einlesen
        // -> user interface aufrufen
        // -> nach jeden programmfeature/menüpunkt das program speichern
        // -> daten wieder serializieren
        // -> und das programm schließen

        //dafür einige tools recherchiert
        //Environment.Exit(0); --> beendet das programm sofort irrelavant wo man ist mit code 0 
        AppControl appControl = new AppControl();
        appControl.RunApp();
    }
}

