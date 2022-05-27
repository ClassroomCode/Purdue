namespace OopDemo;

public class Employee : Person
{
    public double Salary { get; set; }

    public override string FullName => $"{LastName}, {FirstName}";
}
