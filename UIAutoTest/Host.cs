using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Automation.Provider;
using System.Runtime.InteropServices;
using System.Windows.Automation;
using GuiKit.WinInterop;

namespace UIAutoTest
{
    [ComVisible(true)]
    public class Host : Window, IRawElementProviderFragmentRoot
    {
        public Host()
        {
            // Create some controls
            _controls.Add(new Control(this, new Win32.RECT(new Win32.POINT(10, 10), new Win32.SIZE(100, 50)), "Control 1"));
            _controls.Add(new Control(this, new Win32.RECT(new Win32.POINT(10, 70), new Win32.SIZE(100, 50)), "Control 2"));
            _controls.Add(new Control(this, new Win32.RECT(new Win32.POINT(10, 130), new Win32.SIZE(100, 50)), "Control 3"));

            // Focus the first
            _focus = _controls[0];
            _focus.HasFocus = true;
        }

        protected override IntPtr WndProc(uint message, IntPtr wParam, IntPtr lParam)
        {
            switch (message)
            {
                case Win32.WM_CLOSE:
                    Win32.PostQuitMessage(0);
                    break;

                case Win32.WM_SETFOCUS:
                    _focus.HasFocus = true;
                    break;

                case Win32.WM_KILLFOCUS:
                    _focus.HasFocus = false;
                    break;

                case Win32.WM_GETOBJECT:

                    if ((int)lParam.ToInt64() == AutomationInteropProvider.RootObjectId)
                    {
                        return AutomationInteropProvider.ReturnRawElementProvider(Handle, wParam, lParam, this);
                    }
                    break;

                case Win32.WM_KEYDOWN:
                    if (wParam.ToInt32() == Win32.VK_TAB)
                    {
                        SetFocus(GetSibling(_focus, Win32.GetKeyState(Win32.VK_SHIFT) < 0 ? -1 : 1, true));
                    }
                    break;

                case Win32.WM_PAINT:
                {
                    Win32.PAINTSTRUCT ps;
                    var hDC = Win32.BeginPaint(Handle, out ps);
                    Win32.SetBkMode(hDC, Win32.TRANSPARENT);

                    foreach (var c in _controls)
                    {
                        if (c == _focus)
                        {
                            Win32.SetTextColor(hDC, Win32.COLOR_HIGHLIGHTTEXT);
                            Win32.FillRect(hDC, ref c.Bounds, Win32.GetSysColorBrush(Win32.COLOR_HIGHLIGHT));
                            Win32.DrawText(hDC, c.Text, c.Text.Length, ref c.Bounds, Win32.DT_SINGLELINE | Win32.DT_CENTER | Win32.DT_VCENTER);
                        }
                        else
                        {
                            Win32.SetTextColor(hDC, Win32.COLOR_WINDOWTEXT);
                            Win32.FillRect(hDC, ref c.Bounds, Win32.GetSysColorBrush(Win32.COLOR_WINDOW));
                            Win32.DrawText(hDC, c.Text, c.Text.Length, ref c.Bounds, Win32.DT_SINGLELINE | Win32.DT_CENTER | Win32.DT_VCENTER);
                        }
                    }

                    Win32.EndPaint(Handle, ref ps);
                    break;
                }

            }
            return base.WndProc(message, wParam, lParam);
        }

        List<Control> _controls = new List<Control>();
        Control _focus;

        void SetFocus(Control control)
        {
            if (_focus != null)
                _focus.HasFocus = false;

            _focus = control;

            if (_focus != null)
                _focus.HasFocus = true;

            Win32.InvalidateRect(Handle, IntPtr.Zero, false);

//            new AutomationFocusChangedEventArgs(1, _focus.AutomationPeer.RuntimeID)


        }

        public Control GetSibling(Control from, int delta, bool wrap=false)
        {
            int index = _controls.IndexOf(from);
            if (index < 0)
                return null;

            index += delta;

            if (index < 0)
            {
                if (wrap)
                    index = _controls.Count - 1;
                else
                    return null;
            }

            if (index >= _controls.Count)
            {
                if (wrap)
                    index = 0;
                else
                    return null;
            }



            return _controls[index];
        }


        #region IRawElementProviderFragmentRoot
        ProviderOptions IRawElementProviderSimple.ProviderOptions
        {
            get { return ProviderOptions.ServerSideProvider | ProviderOptions.UseComThreading; }
        }

        IRawElementProviderSimple IRawElementProviderSimple.HostRawElementProvider
        {
            get
            {
                return AutomationInteropProvider.HostProviderFromHandle(Handle);
            }
        }

        object IRawElementProviderSimple.GetPropertyValue(int propertyId)
        {
            if (propertyId == AutomationElement.NameProperty.Id)
            {
                return "UI Automation Test (!!)";
            }

            if (propertyId == AutomationElement.HasKeyboardFocusProperty.Id)
            {
                return false;// return Win32.GetFocus() == Handle;
            }

            return null;
        }

        object IRawElementProviderSimple.GetPatternProvider(int patternId)
        {
            return null;
        }


        int[] IRawElementProviderFragment.GetRuntimeId()
        {
            return new int[] { AutomationInteropProvider.AppendRuntimeId, 1 };
        }

        IRawElementProviderFragment IRawElementProviderFragment.Navigate(NavigateDirection direction)
        {
            switch (direction)
            {
                case NavigateDirection.FirstChild:
                    return _controls[0].AutomationPeer;
                case NavigateDirection.LastChild:
                    return _controls[_controls.Count - 1].AutomationPeer;
            }
            return null;
        }

        void IRawElementProviderFragment.SetFocus()
        {
            Win32.SetFocus(Handle);
        }

        System.Windows.Rect IRawElementProviderFragment.BoundingRectangle
        {
            get
            {
                Win32.RECT rc;
                Win32.GetWindowRect(Handle, out rc);
                return new System.Windows.Rect(rc.Left,rc.Top,rc.Width,rc.Height);
            }
        }

        IRawElementProviderFragmentRoot IRawElementProviderFragment.FragmentRoot
        {
            get 
            { 
                return this;        // Or null?
            }
        }

        IRawElementProviderSimple[] IRawElementProviderFragment.GetEmbeddedFragmentRoots()
        {
            return null;
        }

        IRawElementProviderFragment IRawElementProviderFragmentRoot.ElementProviderFromPoint(double x, double y)
        {
            // Convert to client coords
            var pt = new Win32.POINT((int)x, (int)y);
            Win32.ScreenToClient(Handle, ref pt);

            // Hit test each control
            foreach (var c in _controls)
            {
                if (Win32.PtInRect(ref c.Bounds, pt))
                {
                    return c.AutomationPeer;
                }
            }
            return this;
        }

        IRawElementProviderFragment IRawElementProviderFragmentRoot.GetFocus()
        {
            // Return the item with focus
            return _focus.AutomationPeer;
        }
        #endregion
    }
}
