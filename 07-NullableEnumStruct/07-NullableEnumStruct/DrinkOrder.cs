public class DrinkOrder
{
    public int OrderNumber { get; set; }
    public string CustomerName { get; set; }
    public DrinkType Drink { get; set; }
    public DrinkSize Size { get; set; }
    public OrderStatus Status { get; set; }
    public decimal Price { get; private set; }

    public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
    {
        OrderNumber = orderNumber;
        CustomerName = customerName;
        Drink = drink;
        Size = size;
        Status = OrderStatus.New;
        Price = CalculatePrice();
    }

    public decimal CalculatePrice()
    {
        return Drink switch
        {
            DrinkType.Coffee => Size switch
            {
                DrinkSize.Small => 3m,
                DrinkSize.Medium => 4m,
                DrinkSize.Large => 5m,
                _ => 0
            },
            DrinkType.Tea => Size switch
            {
                DrinkSize.Small => 2m,
                DrinkSize.Medium => 3m,
                DrinkSize.Large => 4m,
                _ => 0
            },
            DrinkType.Juice => Size switch
            {
                DrinkSize.Small => 4m,
                DrinkSize.Medium => 5m,
                DrinkSize.Large => 6m,
                _ => 0
            },
            DrinkType.Water => Size switch
            {
                DrinkSize.Small => 1m,
                DrinkSize.Medium => 1.5m,
                DrinkSize.Large => 2m,
                _ => 0
            },
            _ => 0
        };
    }

    public void UpdateStatus(OrderStatus newStatus)
    {
        Status = newStatus;
        Console.WriteLine($"Sifariş #{OrderNumber} statusu: {newStatus}");
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"--- Sifariş Bilgisi ---");
        Console.WriteLine($"No: {OrderNumber} | Müşteri: {CustomerName}");
        Console.WriteLine($"İçki: {Drink} ({Size}) | Qiymet: {Price} AZN");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine("-----------------------");
    }
}
