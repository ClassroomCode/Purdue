namespace OopDemo;

public class Person
{
    public string FirstName = string.Empty;
    public string LastName = string.Empty;

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }
}
