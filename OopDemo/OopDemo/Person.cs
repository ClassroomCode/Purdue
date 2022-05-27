namespace OopDemo;

public abstract class Person
{
    /*
    public Person(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }
    */

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public virtual string FullName => $"{FirstName} {LastName}";
}
