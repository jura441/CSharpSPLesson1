using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MangeWindow
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string windowTitle);

        
        [DllImport("user32.dll")]
        public static extern int SendMessage (IntPtr ptr, uint code, string dop1, string dop2);
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            Process mywindow = new Process();
        
            foreach (Process  process in processes)
            {
                if (process.ProcessName == "AppWindow")
                {
                    mywindow = process;
                    Console.WriteLine(process.ProcessName);
                }

            }
           SendMessage(mywindow.MainWindowHandle, 0x000C, "", "Я твой новый заголовок"); //переименование 

           // SendMessage(mywindow.MainWindowHandle, 0x0010, "", "Я твой новый заголовок"); //закрытие окна
           Console.ReadLine();
        }
    }
}
