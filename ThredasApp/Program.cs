// See https://aka.ms/new-console-template for more information
using System.Threading;


    MyObject myObject = new MyObject();
    myObject.Start = Int32.Parse(Console.ReadLine());
    myObject.End = Int32.Parse(Console.ReadLine());
ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(ConsoleWrite);
    //ThreadStart threadStart = new ThreadStart(ConsoleWrite);
    Thread thread = new Thread(parameterizedThreadStart); 
    thread.IsBackground= true;
    thread.Priority =ThreadPriority.Highest;
    thread.Start();
thread.Join();

static void ConsoleWrite(object my)
{
   int start = ((MyObject)my).Start;
    int end = ((MyObject)my).End;
    string message = ((MyObject)my).Message;
    
    for (int i = start; i <= end; i++)
    {
        Console.WriteLine("Из потока:" + i);
    }
    Console.WriteLine(message);
    

}
class MyObject
{
    public int Start { get; set; }
    public int End { get; set; }
    public string Message { get; set; } 


}
