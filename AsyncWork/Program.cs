
WaitCallback callback = new WaitCallback(Sum);

ThreadPool.SetMinThreads(10, 10);

for(int i=1; i<20; i++)
{
    ThreadPool.QueueUserWorkItem(callback, i*10000);
   
}
ThreadPool.QueueUserWorkItem(callback, 100);

Console.WriteLine("Hello World");
Console.ReadLine();

static void Sum(object count)
    {
    int result = 0;
    for (int i = 0; i < (int)count; i++)
    {
        result += i;
    }
    Console.WriteLine("Номер потока: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine(result);
}