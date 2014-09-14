﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation.Provider;
using GuiKit.WinInterop;

namespace UIAutoTest
{
    public class Control
    {
        public Control(Host host, Win32.RECT bounds, string text)
        {
            Host = host;
            Bounds = bounds;
            Text = text;
        }

        public Host Host;
        public Win32.RECT Bounds;
        public string Text;

        AutomationPeer _peer;
        public AutomationPeer AutomationPeer
        {
            get
            {
                if (_peer == null)
                {
                    _peer = new AutomationPeer()
                    {
                        ClassName = "CompositedControl",
                        FrameworkName = "UIAutoTest",  
                        GetBounds = () =>
                        {
                            var bounds = Bounds;
                            Win32.ClientToScreen(Host.Handle, ref bounds);
                            return bounds;
                        },
                        GetFragmentRoot = () =>
                        {
                            return Host;
                        },
                        SetFocus = () =>
                        {
                        },
                        GetHostRawElementProvider = () =>
                        {
                            return Host;
                        },
                        GetIsContent = () => false,
                        GetIsControl = () => true,
                        NavigateHandler = (dir) => 
                        {
                            switch (dir)
                            {
                                case NavigateDirection.NextSibling:
                                {
                                    var sib = Host.GetSibling(this, 1);
                                    return sib == null ? null : sib.AutomationPeer;
                                }

                                case NavigateDirection.PreviousSibling:
                                {
                                    var sib = Host.GetSibling(this, -1);
                                    return sib == null ? null : sib.AutomationPeer;
                                }
                            }
                            return null;
                        },
                        GetText = () => Text,
                    };
                }

                return _peer;
            }
        }
    }
}
