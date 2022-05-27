namespace OopDemo;

public class Vendor : IPayable
{
    public string Name { get; set; } = string.Empty;

    public void PayMoney()
    {
        Console.WriteLine($"{Name} got paid");
    }
}
