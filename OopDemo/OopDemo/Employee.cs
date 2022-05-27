namespace OopDemo;

public class Employee : Person, IPayable
{
    public double Salary { get; set; }

    public override string FullName => $"{LastName}, {FirstName}";

    public void PayMoney()
    {
        Console.WriteLine($"{FullName} got paid");
    }
}
