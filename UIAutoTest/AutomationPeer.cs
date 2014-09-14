using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Automation.Provider;
using System.Windows.Automation;
using GuiKit.WinInterop;

namespace UIAutoTest
{
    [ComVisible(true)]
    public class AutomationPeer :            
        IRawElementProviderFragment,
        IValueProvider,
        IToggleProvider
    {
        public AutomationPeer()
        {
            _runtimeId = _nextRuntimeId++;
        }


        public object Owner
        {
            get;
            set;
        }

        public string ClassName
        {
            get
            {
                return (string)Properties[AutomationElementIdentifiers.ClassNameProperty.Id];
            }
            set
            {
                Properties[AutomationElementIdentifiers.ClassNameProperty.Id] = value;
            }
        }

        public string FrameworkName
        {
            get
            {
                return (string)Properties[AutomationElementIdentifiers.FrameworkIdProperty.Id];
            }
            set
            {
                Properties[AutomationElementIdentifiers.FrameworkIdProperty.Id] = value;
            }
        }

        public ControlType ControlType
        {
            get
            {
                return (ControlType)Properties[AutomationElementIdentifiers.ControlTypeProperty.Id];
            }
            set
            {
                Properties[AutomationElementIdentifiers.ControlTypeProperty.Id] = value;
            }
        }

        public void SetAutomationId(string value)
        {
            Properties[AutomationElementIdentifiers.AutomationIdProperty.Id] = value;
        }

        public int RuntimeID
        {
            get { return _runtimeId; }
        }

        int _runtimeId;
        static int _nextRuntimeId = 1;

        public Dictionary<int, object> Properties = new Dictionary<int, object>();

        public Func<bool> GetIsContent;
        public Func<bool> GetIsControl;
        protected internal Func<IRawElementProviderSimple> GetHostRawElementProvider;
        public Func<string> GetText;
        public Func<Win32.RECT> GetBounds;
        internal Func<IRawElementProviderFragmentRoot> GetFragmentRoot;
        public Action SetFocus;
        public Func<NavigateDirection, AutomationPeer> NavigateHandler;
        public Func<string> GetValue;
        public Action<string> SetValue;
        public Func<bool?> GetToggleState;
        public Action Toggle;
        public Func<Win32.POINT, AutomationPeer> HitTest;

        System.Windows.Rect IRawElementProviderFragment.BoundingRectangle
        {
            get 
            {
                if (GetBounds != null)
                {
                    var screenRect = GetBounds();
                    return new System.Windows.Rect(screenRect.Left, screenRect.Top, screenRect.Width, screenRect.Height);
                }
                else
                {
                    return new System.Windows.Rect(0, 0, 0, 0);
                }
            }
        }

        IRawElementProviderFragmentRoot IRawElementProviderFragment.FragmentRoot
        {
            get
            {
                if (GetFragmentRoot == null)
                {
                    var parent = NavigateHandler(NavigateDirection.Parent);
                    if (parent != null)
                        return ((IRawElementProviderFragment)parent).FragmentRoot;
                    return null;
                }
                return GetFragmentRoot();
            }
        }

        IRawElementProviderSimple[] IRawElementProviderFragment.GetEmbeddedFragmentRoots()
        {
            return null;
        }

        int[] IRawElementProviderFragment.GetRuntimeId()
        {
            return new int[] { AutomationInteropProvider.AppendRuntimeId, _runtimeId };
        }

        IRawElementProviderFragment IRawElementProviderFragment.Navigate(NavigateDirection direction)
        {
            if (NavigateHandler != null)
            {
                var peer = NavigateHandler(direction);
                if (peer != null)
                    return peer;

                if (direction == NavigateDirection.Parent && GetFragmentRoot != null)
                {
                    return GetFragmentRoot();
                }
            }
            return null;
        }

        void IRawElementProviderFragment.SetFocus()
        {
            if (SetFocus != null)
                SetFocus();
        }

        object IRawElementProviderSimple.GetPatternProvider(int patternId)
        {
            if (patternId == ValuePatternIdentifiers.Pattern.Id)
            {
                if (GetValue != null)
                    return this;
            }

            if (patternId == TogglePatternIdentifiers.Pattern.Id)
            {
                if (GetToggleState != null)
                    return this;
            }

            return null;
        }

        object IRawElementProviderSimple.GetPropertyValue(int propertyId)
        {
            object val;
            if (Properties.TryGetValue(propertyId, out val))
                return val;

            if (propertyId == AutomationElementIdentifiers.NameProperty.Id && GetText != null)
            {
                return GetText();
            }

            if (propertyId == AutomationElementIdentifiers.IsContentElementProperty.Id && GetIsContent != null)
            {
                return GetIsContent;
            }

            if (propertyId == AutomationElementIdentifiers.IsControlElementProperty.Id && GetIsControl != null)
            {
                return GetIsControl;
            }

            return null;
        }

        IRawElementProviderSimple IRawElementProviderSimple.HostRawElementProvider
        {
            get 
            {
                if (GetHostRawElementProvider != null)
                    return GetHostRawElementProvider();
                else
                    return null;
            }
        }

        ProviderOptions IRawElementProviderSimple.ProviderOptions
        {
            get { return ProviderOptions.ServerSideProvider | ProviderOptions.UseComThreading; }
        }

        bool IValueProvider.IsReadOnly
        {
            get { return SetValue == null; }
        }

        void IValueProvider.SetValue(string value)
        {
            if (SetValue != null)
                SetValue(value);
        }

        string IValueProvider.Value
        {
            get
            {
                if (GetValue != null)
                    return GetValue();
                return null;
            }
        }

        void IToggleProvider.Toggle()
        {
            if (Toggle != null)
                Toggle();
        }

        ToggleState IToggleProvider.ToggleState
        {
            get
            {
                if (GetToggleState != null)
                {
                    bool? val = GetToggleState();
                    if (val.HasValue)
                    {
                        return val.Value ? ToggleState.On : ToggleState.Off;
                    }
                    else
                    {
                        return ToggleState.Indeterminate;
                    }
                }
                throw new NotImplementedException();
            }
        }
    }
}
