using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WorkWithNotepad
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr windowHandle, uint message, string addString1, string addString2);
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            Process notepad = new Process();
            foreach (Process process in processes)
            {
                if (process.ProcessName == "notepad")
                {
                    notepad = process; break;
                }
            }
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed = new System.Timers.ElapsedEventHandler();
        }

        public static void UpdateTime(Process process)
        {
            SendMessage(process.MainWindowHandle, 0x0C, string.Empty, DateTime.Now.ToString());
        }
    }
}
