using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using GuiKit.WinInterop;

namespace UIAutoTest
{
    static class Program
    {
        [DllImport("ole32.dll")]
        static extern int OleInitialize(IntPtr pvReserved);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OleInitialize(IntPtr.Zero);

            // Without this, standard accessibility components like title, min button, max button etc appear 
            // in the incorrect location
            Win32.SetProcessDPIAware();

            var host = new Host();

            Win32.MSG msg;
            while (Win32.GetMessage(out msg, IntPtr.Zero, 0, 0))
            {
                Win32.TranslateMessage(ref msg);
                Win32.DispatchMessage(ref msg);
            }

            host.Dispose();
        }
    }
}
