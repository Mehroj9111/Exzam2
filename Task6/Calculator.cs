public class Calculator
{
    public double a;
    public double b;
    public long n;
    public long Factorial()
    {
        int c = 1;
        for (int i = 1; i <= n; i++)
        {
            c *= i;
        }
        return c;
    }
    public double Multiply()
    {
        return a * b;
    }
    public double Division()
    {
        return a / b;
    }
}