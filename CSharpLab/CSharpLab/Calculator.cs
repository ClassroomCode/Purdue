
namespace CSharpLab;

public class Calculator
{
    public int Add(ref int a, ref int b)
    {
        a++;
        b++;

        return a + b;
    }
}
