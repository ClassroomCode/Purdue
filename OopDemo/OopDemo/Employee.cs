namespace OopDemo;

public class Employee : Person, IPayable
{
    /*
    public Employee(string fn, string ln, double salary = 0)
        : base(fn, ln)
    {
        Salary = salary;
    }
    */

    public double Salary { get; set; }

    public override string FullName => $"{LastName}, {FirstName}";

    public void PayMoney()
    {
        Console.WriteLine($"{FullName} got paid");
    }
}
