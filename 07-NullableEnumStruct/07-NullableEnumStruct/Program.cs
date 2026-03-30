class Program
{
    static void Main(string[] args)
    {
      
        DrinkOrder order1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
        order1.DisplayOrder();
        order1.UpdateStatus(OrderStatus.Preparing);
        order1.UpdateStatus(OrderStatus.Ready);
        order1.UpdateStatus(OrderStatus.Delivered);

        Console.WriteLine();

        DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
        order2.DisplayOrder();
        order2.UpdateStatus(OrderStatus.Ready);
        order2.DisplayOrder();

        Console.WriteLine();

        DrinkOrder order3 = new DrinkOrder(103, "Vüqar", DrinkType.Juice, DrinkSize.Small);
        order3.DisplayOrder();

        Console.WriteLine("\n=== ENUM METODLARI ===");

        
        Console.WriteLine("İçki növleri:");
        foreach (var val in Enum.GetValues(typeof(DrinkType))) Console.Write(val + " ");

        Console.WriteLine("\nÖlçüler:");
        foreach (var val in Enum.GetValues(typeof(DrinkSize))) Console.Write(val + " ");

        Console.WriteLine("\nStatuslar:");
        foreach (var val in Enum.GetValues(typeof(OrderStatus))) Console.Write(val + " ");

        
        Console.WriteLine($"\n\nToString Nümunə: {DrinkType.Coffee.ToString()} və {DrinkSize.Large.ToString()}");

        
        DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
        DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
        Console.WriteLine($"Parse Nümunə: {parsedDrink} - {parsedSize}");

        Console.WriteLine("\n=== STATİSTİKA ===");

        
        decimal totalAmount = order1.Price + order2.Price + order3.Price;
        Console.WriteLine($"Ümumi sifariş sayı: 3");
        Console.WriteLine($"Sifariş 1 qiymət: {order1.Price} AZN");
        Console.WriteLine($"Sifariş 2 qiymət: {order2.Price} AZN");
        Console.WriteLine($"Sifariş 3 qiymət: {order3.Price} AZN");
        Console.WriteLine($"Ümumi məbləğ: {totalAmount} AZN");
    }
}
