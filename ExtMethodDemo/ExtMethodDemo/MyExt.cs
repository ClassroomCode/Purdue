namespace ExtMethodDemo;

public static class MyExt
{
    public static int DoubleIt(this int a) => a * 2;

    public static string GetAssembly(this object obj)
    {
        return (obj.GetType().Assembly.GetName().Name ?? "Unknown");
    }
}
