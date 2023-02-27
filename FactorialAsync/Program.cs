// See https://aka.ms/new-console-template for more information

static void Main(string[] args)
{
    Console.WriteLine(Factorial(5).ToString());
    // поточный метод
    Thread thread = new Thread(new ParameterizedThreadStart(FactorialAsync));
    thread.Start(5);

    Thread threadStep = new Thread(new ParameterizedThreadStart(StepenAsync));
    threadStep.Start(new MyPow(5,3));
}



static void FactorialAsync(object obj)
{
    obj = Factorial((int)obj);
    Console.WriteLine(((int)obj).ToString());
}

static void StepenAsync(object obj)
{
    MyPow pow = (MyPow)obj;
    Console.WriteLine(pow.Getresult().ToString());
}


static int Factorial(int n)
{
    int res = 1;    
    for (int i = n; i > 0; i--)
    {
        res *= i;

    }
    return res;
}

class MyPow
{
    int _number;
    int _stepen;

    public MyPow (int number, int stepen)
    {
        _number = number;
        _stepen = stepen;

    }

    public int Getresult()
    {
        int result = 1;
        for(int i=0; i <_stepen; i++)
        {
            result *= _number;
        }
        return result;
    }
}
