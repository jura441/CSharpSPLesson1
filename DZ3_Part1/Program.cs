using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ3_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject(Int32.Parse(Console.ReadLine()));
            myObject.Start = Int32.Parse(Console.ReadLine());
            myObject.End = Int32.Parse(Console.ReadLine());
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(ConsoleWrite);
            ThreadStart threadStart = new ThreadStart(ConsoleWrite);
            Thread thread = new Thread(threadStart);
            for (int i = 0; i < myObject.threads.Length; i++)
            {
                myObject.threads[i] = new Thread(parameterizedThreadStart);
            }
            for (int i = 0; i < myObject.threads.Length; i++)
            {
                myObject.threads[i].Start(myObject);
                myObject.threads[i].Join();
            }
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Lowest;
            thread.Start(myObject);
            thread.Join();
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Из основной программы: " + i);
            }
        }
        static void ConsoleWrite()
        {
            Console.WriteLine("Введите число начала массива");
            int istart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число конца массива");
            int iend = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= 50; i++)
            {
                if (i == 25)
                {
                    Console.ReadLine();
                }
                Console.WriteLine("Из потока: " + i);
            }
        }

        static void ConsoleWrite(object my)
        {
            int start = ((MyObject)my).Start;
            int end = ((MyObject)my).End;
            string message = ((MyObject)my).Message;
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine("Из потока: " + i);
            }
            Console.WriteLine();
        }
        static void SaveDataToFile(object number)
        {
            FileStreamOptions options = new FileStreamOptions();
            options.Access = FileAccess.Write;
            options.Share = FileShare.Write;
            options.Mode = FileMode.OpenOrCreate;
            StreamWriter writer = new StreamWriter("task5.txt", Encoding.UTF8, options);
            writer.WriteLine(number.ToString());
            writer.Close();
        }
    }
    class MyObject
    {
        public int Start { get; set; }
        public int End { get; set; }
        public string Message { get; set; } = "Это читерство";
        public Thread[] threads;
        public MyObject(int countThread)
        {
            if (countThread > 0)
            {
                threads = new Thread[countThread];
            }
            else
            {
                threads = new Thread[1];
            }
        }
    }
    
}
