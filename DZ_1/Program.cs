using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1
{
    internal class Program
    {
            [DllImport("user32.dll")]
            public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

            const uint MB_ICONWARMIMG = 0x030;
            const uint MB_CANCELTRYCONTINUE = 0x06;
            const int MB_DEFBUTTON2 = 0x0100;
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Иванов ", "Title", MB_ICONWARMIMG | MB_CANCELTRYCONTINUE | MB_DEFBUTTON2);
            MessageBox(IntPtr.Zero, "Юрий ", "Title", MB_ICONWARMIMG | MB_CANCELTRYCONTINUE | MB_DEFBUTTON2);
            MessageBox(IntPtr.Zero, "Александрович ", "Title", MB_ICONWARMIMG | MB_CANCELTRYCONTINUE | MB_DEFBUTTON2);
        }
    }
}
