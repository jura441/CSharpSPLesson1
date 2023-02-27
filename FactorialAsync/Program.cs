// See https://aka.ms/new-console-template for more information

Console.WriteLine(Factorial(5).ToString());

static int Factorial(int n)
{
    int res = 1;    
    for (int i = n; i > 0; i--)
    {
        res *= i;

    }
    return res;
}
