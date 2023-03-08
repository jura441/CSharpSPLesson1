using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDZ1
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint code, IntPtr attr1, string attr2);
        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, uint code, int attr1, int attr2);
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string attr1, string attr2, uint code = 0x0);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, String lpWindowName);
        [DllImport("user32.dll")]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("kernel32.dll")]
        static extern bool Beep(int Freq, int dur);
        static void Main(string[] args)
        {
            // Task1 /
            /*MessageBox(IntPtr.Zero, "Юрий", "имя");
            MessageBox(IntPtr.Zero, "Иванов", "фамилия");
            MessageBox(IntPtr.Zero, "Студент", "должность");*/

            // Task2 /

            Process process = new Process();
            process.StartInfo.FileName = "notepad";
            process.Start();
            const int WM_KEYDOWN = 0x100;

            IntPtr notepad = FindWindow("notepad", null);

            IntPtr editx = FindWindowEx(notepad, IntPtr.Zero, "edit", null);

            PostMessage(editx, WM_KEYDOWN, (int)Keys.A, 0);
            Console.WriteLine(FindWindow("notepad", null));
            SendMessage(FindWindow("notepad", null), 0x000C, IntPtr.Zero, "окно скоро закроется");
            PostMessage(FindWindow("notepad", null), 0x0010, (int)Keys.W, 0);
            Console.ReadLine();
            SendMessage(FindWindow("notepad", null), 0x0010, IntPtr.Zero, "");
            Beep(3000, 1000);
            Beep(0, 2500);
            Beep(1000, 1000);
            Console.ReadLine();
        }
    }
}