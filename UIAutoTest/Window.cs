using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GuiKit.WinInterop;

namespace UIAutoTest
{
    public class Window : IDisposable
    {
        public Window()
        {
            // Create window and subclass it
            uint style = Win32.WS_CAPTION | Win32.WS_POPUP | Win32.WS_SYSMENU | Win32.WS_CLIPCHILDREN |
                            Win32.WS_SIZEBOX | Win32.WS_MAXIMIZEBOX | Win32.WS_MINIMIZEBOX | Win32.WS_VISIBLE |
                            Win32.DS_3DLOOK | Win32.DS_MODALFRAME;
            uint exStyle = Win32.WS_EX_LEFT | Win32.WS_EX_LTRREADING | Win32.WS_EX_RIGHTSCROLLBAR | Win32.WS_EX_DLGMODALFRAME |
                            Win32.WS_EX_WINDOWEDGE | Win32.WS_EX_CONTROLPARENT;
            _handle = Win32.CreateWindowEx(exStyle, "#32770", "UI Automation Test", style, 100, 100, 400, 300, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
            _oldWndProc = Win32.GetWindowLongPtr(_handle, (int)Win32.GWL_WNDPROC);
            _newWndProc = new Win32.WNDPROC(SubclassedWndProc);
            Win32.SetWindowLongPtr(_handle, (int)Win32.GWL_WNDPROC, System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(_newWndProc));
        }

        Win32.WNDPROC _newWndProc;
        IntPtr _oldWndProc;

        IntPtr SubclassedWndProc(IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam)
        {
            return WndProc(message, wParam, lParam);
        }

        protected virtual IntPtr WndProc(uint message, IntPtr wParam, IntPtr lParam)
        {
            return Win32.CallWindowProc(_oldWndProc, _handle, message, wParam, lParam);
        }

        IntPtr _handle;
        public IntPtr Handle
        {
            get
            {
                return _handle;
            }
        }

        public void Dispose()
        {
            if (_handle != IntPtr.Zero)
            {
                Win32.DestroyWindow(_handle);
                _handle = IntPtr.Zero;
            }
        }

    }
}
