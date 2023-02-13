using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace WorkWithNotepad
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr windowHandle, uint message, string addString1, string addString2);
        public static Process notepad;
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            notepad = new Process();
            foreach (Process process in processes)
            {
                if (process.ProcessName == "notepad")
                {
                    Program.notepad = process; break;
                }
            }


            System.Timers.Timer timer = new System.Timers.Timer(1000);

            ElapsedEventHandler handler = new ElapsedEventHandler(UpdateTimeEvent);
            timer.Elapsed += handler;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();

            Console.ReadLine();
        }

        public static void UpdateTimeEvent(object obj, ElapsedEventArgs e)
        {
            SendMessage(notepad.MainWindowHandle, 0x0C, string.Empty, DateTime.Now.ToString());
        }
    }
}
