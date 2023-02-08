using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSharpSPLesson1
{
    internal class Program
    {
        [DllImport ("user32.dll")]
        public static extern int MessageBox (IntPtr hWnd, string lpText, string lpCaption, uint uType);
        
        [DllImport ("user32.dll")]
        public static extern IntPtr FindWindowW (string lpClassName, string lpWindowName);
        
        [DllImport ("user32.dll")]
        public static extern long SendMesageW (IntPtr hWnd, uint Msg, string wParam, uint lParam);


        const uint MB_ICONWARMIMG = 0x030;
        const uint MB_CANCELTRYCONTINUE = 0x06;
        const int MB_DEFBUTTON2 = 0x0100;
        const int MB_YESNOCANCEL = 0x03;

        static int MyMessageBox(int number)
        {
            return MessageBox(IntPtr.Zero, "YES - число угадано верно," + "NO - загаданное число меньше," + "CANCEL - загаднное число больше \n Может быть вы загадали" + number.ToString(),
                "Угадай число", MB_YESNOCANCEL | MB_DEFBUTTON2);

        }

        static void Main(string[] args)

        {
            string caption = "";

            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (p.ProcessName == "notepad")
                {
                    caption = p.MainWindowTitle;
                }

            }
            Console.WriteLine(caption);
            IntPtr ptr = FindWindowW("notepad", caption);
            IntPtr ptr2 = FindWindowW("notepad", "Безымянный - Блокнот");
            Console.ReadLine();

            //Задача 2 самостоятельная работа

            //2-cancel, yes- 6, no- 7
            //MessageBox(IntPtr.Zero, "Hello World", "Title", MB_ICONWARMIMG | MB_CANCELTRYCONTINUE | MB_DEFBUTTON2);

            //int minNumber = 0;
            //int maxNumber = 100;
            //Random random = new Random();
            //int result = random.Next(minNumber, maxNumber);
            //int answer = 0;
            //while((answer = MyMessageBox(result)) != 6)
            //{
            //    if (answer == 2)
            //    {
            //        minNumber = result;
            //        result = random.Next(minNumber, maxNumber);
            //    }
            //    if (answer == 7)
            //    {
            //        maxNumber = result;
            //        result = random.Next(minNumber, maxNumber);
            //    }
            //}
            //MessageBox(IntPtr.Zero, "Ура, число совпало! Число" + result.ToString(), "Число угадано", 0x0);


            //Process process = new Process();
            //process.StartInfo = new ProcessStartInfo("notepad.exe");
            //process.Start();
            //process.WaitForExit();
            ////process.Kill(); немедленно убить процесс
            ////process.CloseMainWindow();  убирает интерфейсную часть процесса(его главное окно)
            //process.Close(); // высвобождает ресурсы выделенные на процесс

            //Console.WriteLine("После закрытия");



            //Process[] processes = Process.GetProcesses();
            //foreach (Process p in processes)
            //{
            //    Console.WriteLine("{0, -35} {1,10}", p.ProcessName,  p.Id);

            //}
            //Console.ReadLine();

            //Process process = new Process();
            //process.StartInfo = new ProcessStartInfo("notepad.exe");
            //Console.WriteLine(process.Handle);
        }
    }
}
