using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace GuiKit.WinInterop
{
	public class Win32
	{
        [StructLayout(LayoutKind.Sequential)]
        public struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public uint code;         // NM_ code
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct MinMaxInfo
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct MEASUREITEMSTRUCT 
        {
            public uint CtlType;
            public uint CtlID;
            public uint itemID;
            public uint itemWidth;
            public uint itemHeight;
            public IntPtr itemData;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct DRAWITEMSTRUCT
        {
            public uint CtlType;
            public uint CtlID;
            public uint itemID;
            public uint itemAction;
            public uint itemState;
            public IntPtr hwndItem;
            public IntPtr hDC;
            public RECT rcItem;
            public IntPtr itemData;
        };

        public const uint ODS_SELECTED = 0x0001;
        public const uint ODS_GRAYED = 0x0002;
        public const uint ODS_DISABLED = 0x0004;
        public const uint ODS_CHECKED = 0x0008;
        public const uint ODS_FOCUS = 0x0010;

        public const uint WM_ACTIVATE = 0x0006;
		public const uint WM_SETFOCUS = 0x0007;
		public const uint WM_KILLFOCUS = 0x008;
        public const uint WM_ENABLE = 0x000A;
        public const uint WM_SETREDRAW = 0x000B;
        public const uint WM_ACTIVATEAPP = 0x001C;
        public const uint WM_CANCELMODE = 0x001F;
        public const uint WM_SETCURSOR = 0x0020;
        public const uint WM_NEXTDLGCTL = 0x0028;
		public const uint WM_ENTERIDLE = 0x0121;
		public const uint WM_CLOSE = 0x0010;
		public const uint WM_SIZE = 0x0005;
        public const uint WM_WINDOWPOSCHANGING = 0x0046;
        public const uint WM_WINDOWPOSCHANGED = 0x0047;
        public const uint WM_MOUSEACTIVATE = 0x0021;

        public const uint WM_GETOBJECT = 0x003D;

        public const int MA_ACTIVATE = 1;
        public const int MA_ACTIVATEANDEAT = 2;
        public const int MA_NOACTIVATE = 3;
        public const int MA_NOACTIVATEANDEAT = 4;

		public const uint WM_SETFONT = 0x0030;
		public const uint WM_GETFONT = 0x0031;
		public const uint WM_COMMAND = 0x0111;
        public const uint WM_SYSCOMMAND = 0x0112;
        public const uint WM_USER = 0x0400;
		public const uint WM_GETDLGCODE = 0x0087;
        public const uint WM_INITDIALOG = 0x0110;
        public const uint WM_CREATE = 0x0001;
        public const uint WM_DESTROY = 0x0002;
        public const uint WM_NCCREATE = 0x0081;
        public const uint WM_NCDESTROY = 0x0082;
        public const uint WM_GETMINMAXINFO = 0x0024;
        public const uint WM_HSCROLL = 0x0114;
        public const uint WM_VSCROLL = 0x0115;
        public const uint WM_PAINT = 0x000F;
        public const uint WM_NCPAINT = 0x0085;
        public const uint WM_NCCALCSIZE = 0x0083;
        public const uint WM_SHOWWINDOW = 0x0018;
        public const uint WM_QUIT = 0x0012;

        public const uint WM_CHANGEUISTATE = 0x0127;
        public const uint WM_UPDATEUISTATE = 0x0128;
        public const uint WM_QUERYUISTATE = 0x0129;

        public const uint UIS_CLEAR = 2;
        public const uint UIS_INITIALIZE = 3;
        public const uint UIS_SET = 1;

        public const uint UISF_ACTIVE = 0x04;
        public const uint UISF_HIDEACCEL = 0x02;
        public const uint UISF_HIDEFOCUS = 0x01;

        public const uint WM_ENTERSIZEMOVE = 0x0231;
        public const uint WM_EXITSIZEMOVE = 0x0232;

        public const uint WM_ERASEBKGND = 0x0014;
        public const uint WM_DRAWITEM = 0x002B;
        public const uint WM_MEASUREITEM = 0x002C;
        public const uint WM_VKEYTOITEM = 0x002E;
        public const uint WM_CHARTOITEM = 0x002F;
        public const uint WM_CTLCOLORMSGBOX = 0x0132;
        public const uint WM_CTLCOLOREDIT = 0x0133;
        public const uint WM_CTLCOLORLISTBOX = 0x0134;
        public const uint WM_CTLCOLORBTN = 0x0135;
        public const uint WM_CTLCOLORDLG = 0x0136;
        public const uint WM_CTLCOLORSCROLLBAR = 0x0137;
        public const uint WM_CTLCOLORSTATIC = 0x0138;
        public const uint WM_NOTIFY = 0x004E;
        public const uint WM_SETICON = 0x0080;
        public const uint WM_INITMENU = 0x0116;
        public const uint WM_INITMENUPOPUP = 0x0117;
        public const uint WM_REFLECTBASE = 0x1c00;             // Matches OCM__BASE
        public const uint WM_KEYDOWN = 0x0100;
        public const uint WM_KEYUP = 0x0101;
        public const uint WM_CHAR = 0x0102;
        public const uint WM_SYSKEYDOWN = 0x0104;
        public const uint WM_SYSKEYUP = 0x0105;
        public const uint WM_SYSCHAR = 0x0106;
        public const uint WM_MOUSEMOVE = 0x0200;
        public const uint WM_LBUTTONDOWN = 0x0201;
        public const uint WM_LBUTTONUP = 0x0202;
        public const uint WM_LBUTTONDBLCLK = 0x0203;
        public const uint WM_RBUTTONDOWN = 0x0204;
        public const uint WM_RBUTTONUP = 0x0205;
        public const uint WM_RBUTTONDBLCLK = 0x0206;
        public const uint WM_MBUTTONDOWN = 0x0207;
        public const uint WM_MBUTTONUP = 0x0208;
        public const uint WM_NCLBUTTONDOWN = 0x00A1;
        public const uint WM_NCLBUTTONUP = 0x00A2;
        public const uint WM_NCLBUTTONDBLCLK = 0x00A3;
        public const uint WM_NCRBUTTONDOWN = 0x00A4;
        public const uint WM_NCRBUTTONUP = 0x00A5;
        public const uint WM_NCRBUTTONDBLCLK = 0x00A6;
        public const uint WM_NCMBUTTONDOWN = 0x00A7;
        public const uint WM_NCMBUTTONUP = 0x00A8;
        public const uint WM_NCMBUTTONDBLCLK = 0x00A9;

        public const uint WM_MOUSEWHEEL = 0x020A;
        public const uint WM_MOUSEHWHEEL = 0x020E;
        public const uint WM_MOUSELEAVE = 0x02A3;
        public const uint WM_CAPTURECHANGED = 0x0215;
        public const uint WM_CONTEXTMENU = 0x007B;

        public const uint WM_MOUSEFIRST = 0x0200;
        public const uint WM_MOUSELAST = 0x020D;
        public const uint WM_NCMOUSEFIRST = 0x00A0;
        public const uint WM_NCMOUSELAST = 0x00A9;
        public const uint WM_SYSKEYFIRST = 0x0104;
        public const uint WM_SYSKEYLAST = 0x0107;
        public const uint WM_KEYFIRST = 0x0100;
        public const uint WM_KEYLAST = 0x0109;

        public const uint WM_POWERBROADCAST = 0x0218;

        public const int PBT_APMQUERYSUSPEND = 0x0000;
        public const int PBT_APMQUERYSTANDBY = 0x0001;
        public const int PBT_APMQUERYSUSPENDFAILED = 0x0002;
        public const int PBT_APMQUERYSTANDBYFAILED = 0x0003;
        public const int PBT_APMSUSPEND = 0x0004;
        public const int PBT_APMSTANDBY = 0x0005;
        public const int PBT_APMRESUMECRITICAL = 0x0006;
        public const int PBT_APMRESUMESUSPEND = 0x0007;
        public const int PBT_APMRESUMESTANDBY = 0x0008;
        public const int PBT_APMBATTERYLOW = 0x0009;
        public const int PBT_APMPOWERSTATUSCHANGE = 0x000A;
        public const int PBT_APMOEMEVENT = 0x000B;
        public const int PBT_APMRESUMEAUTOMATIC = 0x0012;

        public const int PBTF_APMRESUMEFROMFAILURE = 0x00000001;

        public const uint BROADCAST_QUERY_DENY = 0x424D5144;

        public const int SC_SCREENSAVE = 0xF140;
        public const int SC_MONITORPOWER = 0xF170;

		public const uint DM_GETDEFID = WM_USER + 0;
		public const uint DM_SETDEFID = WM_USER + 1;
		public const uint DM_REPOSITION = WM_USER + 2;

        public const uint LB_INSERTSTRING = 0x0181;
        public const uint LB_DELETESTRING = 0x0182;
        public const uint LB_SETCURSEL = 0x0186;
        public const uint LB_GETCURSEL = 0x0188;
        public const uint LB_GETTOPINDEX = 0x018E;
        public const uint LB_GETSELCOUNT = 0x0190;
        public const uint LB_GETSELITEMS = 0x0191;
        public const uint LB_SETSEL = 0x0185;
        public const uint LB_GETSEL = 0x0187;
        public const uint LB_RESETCONTENT = 0x0184;
        public const uint LB_GETITEMRECT = 0x0198;

        public const int LBN_SELCHANGE = 1;
        public const int LBN_DBLCLK = 2;

		public const uint DLGC_WANTARROWS     = 0x0001;      /* Control wants arrow keys         */
		public const uint DLGC_WANTTAB        = 0x0002;      /* Control wants tab keys           */
		public const uint DLGC_WANTALLKEYS    = 0x0004;      /* Control wants all keys           */
		public const uint DLGC_WANTMESSAGE    = 0x0004;      /* Pass message to control          */
		public const uint DLGC_HASSETSEL      = 0x0008;      /* Understands EM_SETSEL message    */
		public const uint DLGC_DEFPUSHBUTTON  = 0x0010;      /* Default pushbutton               */
		public const uint DLGC_UNDEFPUSHBUTTON = 0x0020;     /* Non-default pushbutton           */
		public const uint DLGC_RADIOBUTTON    = 0x0040;      /* Radio button                     */
		public const uint DLGC_WANTCHARS      = 0x0080;      /* Want WM_CHAR messages            */
		public const uint DLGC_STATIC         = 0x0100;      /* Static item: don't include       */
		public const uint DLGC_BUTTON         = 0x2000;      /* Button item: can be checked      */

        public const int VK_TAB = 0x09;
		public const int VK_ESCAPE = 0x1B;
        public const int VK_SHIFT = 0x10;
        public const int VK_CONTROL = 0x11;
        public const int VK_ALT = 0x12;

        public const ushort BN_CLICKED = 0;

        public const uint BM_GETCHECK = 0x00F0;
		public const uint BM_SETCHECK = 0x00F1;
		public const uint BM_SETSTYLE = 0x00F4;

        public const uint BS_DEFPUSHBUTTON = 0x00000001;
        public const uint BS_AUTOCHECKBOX = 0x00000003;
		public const uint BS_AUTO3STATE = 0x00000006;
        public const uint BS_GROUPBOX = 0x00000007;
        public const uint BS_AUTORADIOBUTTON = 0x00000009;
		public const uint BS_MULTILINE = 0x00002000;
        public const uint BS_PUSHLIKE = 0x00001000;
        public const uint BS_TYPEMASK = 0x0000000F;

        public const uint LBS_NOTIFY = 0x0001;
		public const uint LBS_SORT = 0x0002;
        public const uint LBS_HASSTRINGS = 0x0040;
        public const uint LBS_EXTENDEDSEL = 0x0800;
        public const uint LBS_NOINTEGRALHEIGHT = 0x0100;
        public const uint LBS_OWNERDRAWFIXED = 0x0010;
        public const uint LBS_OWNERDRAWVARIABLE = 0x0020;

        public const uint SS_LEFT = 0x0000;
        public const uint SS_CENTER = 0x0001;
        public const uint SS_RIGHT = 0x0002;
        public const uint SS_ICON = 0x0003;

        public const uint STM_SETICON = 0x0170;

        public const uint ES_LEFT = 0x0000;
        public const uint ES_CENTER = 0x0001;
        public const uint ES_RIGHT = 0x0002;
        public const uint ES_MULTILINE = 0x0004;
        public const uint ES_UPPERCASE = 0x0008;
        public const uint ES_LOWERCASE = 0x0010;
        public const uint ES_PASSWORD = 0x0020;
        public const uint ES_AUTOVSCROLL = 0x0040;
        public const uint ES_AUTOHSCROLL = 0x0080;
        public const uint ES_NOHIDESEL = 0x0100;
        public const uint ES_OEMCONVERT = 0x0400;
        public const uint ES_READONLY = 0x0800;
        public const uint ES_WANTRETURN = 0x1000;
        public const uint ES_NUMBER = 0x2000;
        
        public const uint EM_SETREADONLY = 0x00CF;
        public const uint EM_REPLACESEL = 0x00C2;
        public const uint EM_SETCUEBANNER = 0x1501;

        public const uint EN_CHANGE = 0x0300;

        public const uint WS_EX_ACCEPTFILES = 0x00000010;
		public const uint WS_EX_APPWINDOW = 0x00040000;
		public const uint WS_EX_CLIENTEDGE = 0x00000200;
		public const uint WS_EX_COMPOSITED = 0x02000000;
		public const uint WS_EX_CONTEXTHELP = 0x00000400;
		public const uint WS_EX_CONTROLPARENT = 0x00010000;
		public const uint WS_EX_DLGMODALFRAME = 0x00000001;
		public const uint WS_EX_LAYERED = 0x00080000;
		public const uint WS_EX_LAYOUTRTL = 0x00400000;
		public const uint WS_EX_LEFT = 0x00000000;
		public const uint WS_EX_LEFTSCROLLBAR = 0x00004000;
		public const uint WS_EX_LTRREADING = 0x00000000;
		public const uint WS_EX_MDICHILD = 0x00000040;
		public const uint WS_EX_NOACTIVATE = 0x08000000;
		public const uint WS_EX_NOINHERITLAYOUT = 0x00100000;
		public const uint WS_EX_NOPARENTNOTIFY = 0x00000004;
		public const uint WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE;
		public const uint WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST;
		public const uint WS_EX_RIGHT = 0x00001000;
		public const uint WS_EX_RIGHTSCROLLBAR = 0x00000000;
		public const uint WS_EX_RTLREADING = 0x00002000;
		public const uint WS_EX_STATICEDGE = 0x00020000;
		public const uint WS_EX_TOOLWINDOW = 0x00000080;
		public const uint WS_EX_TOPMOST = 0x00000008;
		public const uint WS_EX_TRANSPARENT = 0x00000020;
		public const uint WS_EX_WINDOWEDGE = 0x00000100;

        public const uint WS_OVERLAPPED = 0x00000000;
		public const uint WS_POPUP = 0x80000000;
		public const uint WS_CHILD = 0x40000000;
		public const uint WS_MINIMIZE = 0x20000000;
		public const uint WS_VISIBLE = 0x10000000;
		public const uint WS_DISABLED = 0x08000000;
		public const uint WS_CLIPSIBLINGS = 0x04000000;
		public const uint WS_CLIPCHILDREN = 0x02000000;
		public const uint WS_MAXIMIZE = 0x01000000;
		public const uint WS_CAPTION = 0x00C00000;
		public const uint WS_BORDER = 0x00800000;
		public const uint WS_DLGFRAME = 0x00400000;
		public const uint WS_VSCROLL = 0x00200000;
		public const uint WS_HSCROLL = 0x00100000;
		public const uint WS_SYSMENU = 0x00080000;
		public const uint WS_THICKFRAME = 0x00040000;
		public const uint WS_GROUP = 0x00020000;
		public const uint WS_TABSTOP = 0x00010000;
		public const uint WS_MINIMIZEBOX = 0x00020000;
		public const uint WS_MAXIMIZEBOX = 0x00010000;
		public const uint WS_TILED = WS_OVERLAPPED;
		public const uint WS_ICONIC = WS_MINIMIZE;
		public const uint WS_SIZEBOX = WS_THICKFRAME;
		public const uint WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;
		public const uint WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX;
		public const uint WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU;
		public const uint WS_CHILDWINDOW = WS_CHILD;

		public const uint SWP_ASYNCWINDOWPOS = 0x4000;
		public const uint SWP_DEFERERASE = 0x2000;
		public const uint SWP_DRAWFRAME = 0x0020;
		public const uint SWP_FRAMECHANGED = 0x0020;
		public const uint SWP_HIDEWINDOW = 0x0080;
		public const uint SWP_NOACTIVATE = 0x0010;
		public const uint SWP_NOCOPYBITS = 0x0100;
		public const uint SWP_NOMOVE = 0x0002;
		public const uint SWP_NOOWNERZORDER = 0x0200;
		public const uint SWP_NOREDRAW = 0x0008;
		public const uint SWP_NOREPOSITION = 0x0200;
		public const uint SWP_NOSENDCHANGING = 0x0400;
		public const uint SWP_NOSIZE = 0x0001;
		public const uint SWP_NOZORDER = 0x0004;
		public const uint SWP_SHOWWINDOW = 0x0040;

		public const uint DS_ABSALIGN         =0x01;
		public const uint DS_SYSMODAL         =0x02;
		public const uint DS_LOCALEDIT        =0x20;
		public const uint DS_SETFONT          =0x40;
		public const uint DS_MODALFRAME       =0x80;
		public const uint DS_NOIDLEMSG        =0x100;
		public const uint DS_SETFOREGROUND    =0x200;
		public const uint DS_3DLOOK          =0x0004;
		public const uint DS_FIXEDSYS         =0x0008;
		public const uint DS_NOFAILCREATE     =0x0010;
		public const uint DS_CONTROL          =0x0400;
		public const uint DS_CENTER           =0x0800;
		public const uint DS_CENTERMOUSE      =0x1000;
		public const uint DS_CONTEXTHELP      =0x2000;
		public const uint DS_SHELLFONT = (DS_SETFONT | DS_FIXEDSYS);

		public const int SW_HIDE = 0;
		public const int SW_NORMAL = 1;
		public const int SW_SHOWNORMAL = 1;
		public const int SW_SHOWMINIMIZED = 2;
		public const int SW_MAXIMIZE = 3;
		public const int SW_SHOWMAXIMIZED = 3;
		public const int SW_SHOWNOACTIVATE = 4;
		public const int SW_SHOW = 5;
		public const int SW_MINIMIZE = 6;
		public const int SW_SHOWMINNOACTIVE = 7;
		public const int SW_SHOWNA = 8;
		public const int SW_RESTORE = 9;
		public const int SW_SHOWDEFAULT = 10;
		public const int SW_FORCEMINIMIZE = 11;

		public const int GWL_EXSTYLE = -20;
		public const int GWL_P_HINSTANCE = -6;
		public const int GWL_P_HWNDPARENT = -8;
		public const int GWL_ID = -12;
		public const int GWL_STYLE = -16;
		public const int GWL_USERDATA = -21;
		public const int GWL_WNDPROC = -4;

		public const int DWL_P_USER = 0x8;
		public const int DWL_P_MSGRESULT = 0x0;
		public const int DWL_P_DLGPROC = 0x4;

		public const uint PM_NOREMOVE = 0x0000;
		public const uint PM_REMOVE = 0x0001;
		public const uint PM_NOYIELD = 0x0002;

        public const int HWND_TOPMOST = -1;
		public const int HWND_NOTOPMOST = -2;
		public const int HWND_TOP = 0;
		public const int HWND_BOTTOM = 1;

		[StructLayout(LayoutKind.Sequential)]
		public struct MSG
		{
			public IntPtr hWnd;
			public uint message;
			public IntPtr wParam;
			public IntPtr lParam;
			public uint time;
			public POINT p;
		}

        public delegate IntPtr WNDPROC(IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam);

        public const uint CS_VREDRAW = 0x00000001;
        public const uint CS_HREDRAW = 0x00000002;
        public const uint CS_DBLCLKS = 0x00000008;
        public const uint CS_OWNDC = 0x00000020;
        public const uint CS_CLASSDC = 0x00000040;
        public const uint CS_PARENTDC = 0x00000080;
        public const uint CS_NOCLOSE = 0x00000200;
        public const uint CS_SAVEBITS = 0x00000800;
        public const uint CS_BYTEALIGNCLIENT = 0x00001000;
        public const uint CS_BYTEALIGNWINDOW = 0x00002000;
        public const uint CS_GLOBALCLASS = 0x00004000;
        public const uint CS_IME = 0x00010000;
        public const uint CS_DROPSHADOW = 0x00020000;

        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("00000122-0000-0000-C000-000000000046")] // This is the value of IID_IDropTarget from the Platform SDK.
        [ComImport]
        public interface IDropTarget
        {
            void DragEnter([In] IDataObject dataObject, [In] uint keyState, [In] Win32.POINT pt, [In, Out] ref uint effect);
            void DragOver([In] uint keyState, [In] Win32.POINT pt, [In, Out] ref uint effect);
            void DragLeave();
            void Drop([In] IDataObject dataObject, [In] uint keyState, [In] Win32.POINT pt, [In, Out] ref uint effect);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32.dll", SetLastError=true)]
        [return: MarshalAs(UnmanagedType.Bool)] /* unnecessary, isn't it? */
        public static extern bool FreeLibrary(IntPtr hModule);

        public static bool IsApiAvailable(string module, string function)
        {
            var lib = LoadLibrary(module);
            if (lib == IntPtr.Zero)
                return false;

            var proc = GetProcAddress(lib, function);
            FreeLibrary(lib);

            return proc != IntPtr.Zero;
        }


        public const uint CF_TEXT = 1;
        public const uint CF_UNICODETEXT = 13;
        public const uint CF_HDROP = 15;

        [DllImport("ole32.dll")]
        public static extern int OleSetClipboard(IDataObject pDataObj);

        [DllImport("ole32.dll")]
        public static extern int OleFlushClipboard();

        [DllImport("ole32.dll")]
        public static extern int OleGetClipboard(out IDataObject ppDataObj);

        [DllImport("user32.dll", SetLastError = true, EntryPoint="RegisterClipboardFormatW")]
        public static extern uint RegisterClipboardFormat([MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);

        [DllImport("ole32.dll")]
        public static extern uint RegisterDragDrop(IntPtr hWnd, IDropTarget dropTarget);

        [DllImport("ole32.dll")]
        public static extern uint RevokeDragDrop(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnlock(IntPtr hMem);

        [DllImport("kernel32.dll")]
        public static extern UIntPtr GlobalSize(IntPtr hMem);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        public static extern int DragQueryFile(IntPtr hDrop, int iFile, [Out] StringBuilder lpszFile, int cch);

        [DllImport("ole32.dll")]
        public static extern void ReleaseStgMedium(ref STGMEDIUM medium);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetProcessDPIAware();

        [StructLayout(LayoutKind.Sequential)]
        public struct WNDCLASS
        {
            public uint style;
            [MarshalAs(UnmanagedType.FunctionPtr)]
            public WNDPROC lpfnWndProc;
            public int cbClsExtra;
            public int cbWndExtra;
            public IntPtr hInstance;
            public IntPtr hIcon;
            public IntPtr hCursor;
            public IntPtr hbrBackground;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpszMenuName;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpszClassName;
        }
        [DllImport("user32.dll", EntryPoint="RegisterClassW")]
        public static extern ushort RegisterClass([In] ref WNDCLASS lpWndClass);

        [DllImport("user32.dll")]
        public static extern bool IsWindowUnicode(IntPtr Handle);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint="CreateWindowExW")]
		public static extern IntPtr CreateWindowEx(
		   uint dwExStyle,
		   string lpClassName,
		   string lpWindowName,
		   uint dwStyle,
		   int x,
		   int y,
		   int nWidth,
		   int nHeight,
		   IntPtr hWndParent,
		   IntPtr hMenu,
		   IntPtr hInstance,
		   IntPtr lpParam);

        [DllImport("user32.dll")]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32.dll")]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyWindow(IntPtr hwnd);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern IntPtr GetFocus();

        [DllImport("user32.dll")]
        public static extern IntPtr SetFocus(IntPtr hwnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr SetCapture(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetCapture();

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(bool Lock);

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public POINT ptMinPosition;
            public POINT ptMaxPosition;
            public RECT rcNormalPosition;
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowPlacement(IntPtr hWnd, out WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPlacement(IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll")]
		public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

		[DllImport("user32.dll")]
		public static extern bool EndDeferWindowPos(IntPtr hDWP);

		[DllImport("user32.dll")]
		public static extern IntPtr DeferWindowPos(IntPtr hDWP, IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern bool SetWindowText(IntPtr hwnd, String lpString);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, uint message, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, uint message, IntPtr wParam, [In, Out] ref RECT rc);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);

        [StructLayout(LayoutKind.Sequential)]
        public struct TRACKMOUSEEVENT
        {
            public int cbSize;
            public uint dwFlags;
            public IntPtr hWnd;
            public uint dwHoverTime;
        }        

        public const uint TME_CANCEL = 0x80000000;
        public const uint TME_HOVER = 0x00000001;
        public const uint TME_LEAVE = 0x00000002;
        public const uint TME_NONCLIENT = 0x00000010;
        public const uint TME_QUERY = 0x40000000;
        
        [StructLayout(LayoutKind.Sequential)]
        public struct LVITEM
        {
            public uint mask;
            public int iItem;
            public int iSubItem;
            public uint state;
            public uint stateMask;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszText;
            public int cchTextMax;
            public int iImage;
            public IntPtr lParam;
            public int iIndent;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LVCOLUMN
        {
            public uint mask;
            public int fmt;
            public int cx;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszText;
            public int cchTextMax;
            public int iSubItem;
            public int iImage;
            public int iOrder;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessageW")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint message, IntPtr wParam, ref LVITEM item);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessageW")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint message, IntPtr wParam, ref LVCOLUMN column);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PostMessage(IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern void PostQuitMessage(int nExitCode);

		[DllImport("user32")]
		public static extern IntPtr CallWindowProc(IntPtr wndProc, IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern IntPtr SetTimer(IntPtr hWnd, IntPtr nIDEvent, uint uElapse, TIMERPROC lpTimerFunc);

        public delegate void TIMERPROC(IntPtr hWnd, uint uMsg, IntPtr nIDEvent, uint dwTime);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref uint pvParam, uint fWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool SystemParametersInfo(uint action, uint intParam, ref Win32.NONCLIENTMETRICS metrics, uint update);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref int pvParam, uint fWinIni); // T = any type

        // or alternatively
        [DllImport("user32.dll", ExactSpelling = true)]
        static extern IntPtr SetTimer(IntPtr hWnd, IntPtr nIDEvent, uint uElapse, IntPtr lpTimerFunc);

        [DllImport("user32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer(IntPtr hWnd, IntPtr uIDEvent);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowVisible(IntPtr hWnd);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32")]
        public static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        public const int AW_HOR_POSITIVE = 0x00000001;
        public const int AW_HOR_NEGATIVE = 0x00000002;
        public const int AW_VER_POSITIVE = 0x00000004;
        public const int AW_VER_NEGATIVE = 0x00000008;
        public const int AW_CENTER = 0x00000010;
        public const int AW_HIDE = 0x00010000;
        public const int AW_ACTIVATE = 0x00020000;
        public const int AW_SLIDE = 0x00040000;
        public const int AW_BLEND = 0x00080000;

        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;

        [DllImport("user32.dll")]
        public static extern bool RedrawWindow(IntPtr hWnd, [In] ref RECT lprcUpdate, IntPtr hrgnUpdate, int flags);

        [DllImport("user32.dll")]
        public static extern bool RedrawWindow(IntPtr hWnd, [In] IntPtr lprcUpdate, IntPtr hrgnUpdate, int flags);

        public const int RDW_INVALIDATE = 0x0001;
        public const int RDW_INTERNALPAINT = 0x0002;
        public const int RDW_ERASE = 0x0004;
        public const int RDW_VALIDATE = 0x0008;
        public const int RDW_NOINTERNALPAINT = 0x0010;
        public const int RDW_NOERASE = 0x0020;
        public const int RDW_NOCHILDREN = 0x0040;
        public const int RDW_ALLCHILDREN = 0x0080;
        public const int RDW_UPDATENOW = 0x0100;
        public const int RDW_ERASENOW = 0x0200;
        public const int RDW_FRAME = 0x0400;
        public const int RDW_NOFRAME = 0x0800;


        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", CharSet=CharSet.Unicode)]
		public static extern uint SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

		public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
		{
			if (IntPtr.Size == 8)
				return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
			else
			{
                return (IntPtr)SetWindowLong(hWnd, nIndex, (uint)dwNewLong.ToInt32());
			}
		}

		public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
		{
			if (IntPtr.Size == 8)
				return GetWindowLongPtr64(hWnd, nIndex);
			else
			{
                return (IntPtr)GetWindowLong(hWnd, nIndex);
			}
		}

		[DllImport("user32.dll", EntryPoint = "SetWindowLongPtrW", CharSet=CharSet.Unicode)]
		private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

		[DllImport("user32.dll", EntryPoint = "GetWindowLongPtrW", CharSet=CharSet.Unicode)]
		static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
		public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessage(out MSG msg, IntPtr hWnd, uint wMsgFilterMin,
           uint wMsgFilterMax, uint wRemoveMsg);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("user32.dll")]
		public static extern bool WaitMessage();

		[DllImport("user32.dll")]
		public static extern bool IsDialogMessage(IntPtr hDlg, [In] ref MSG lpMsg);

		[DllImport("user32.dll")]
		public static extern bool TranslateMessage([In] ref MSG lpMsg);

		[DllImport("user32.dll")]
		public static extern IntPtr DispatchMessage([In] ref MSG lpmsg);

		[DllImport("user32.dll", SetLastError = false)]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetActiveWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[DllImport("user32.dll")]
		public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern bool InflateRect(ref RECT lprc, int dx, int dy);

        [DllImport("user32.dll")]
        public static extern bool IntersectRect(out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

        [DllImport("user32.dll")]
        public static extern bool OffsetRect(ref RECT lprc, int dx, int dy);

        [DllImport("user32.dll")]
        public static extern bool PtInRect([In] ref RECT lprc, POINT pt);

        [DllImport("user32.dll")]
        public static extern bool DrawEdge(IntPtr hdc, ref RECT qrc, uint edge, uint grfFlags);

		[DllImport("user32.dll")]
		public static extern bool IsZoomed(IntPtr hWnd);

        public const uint BDR_RAISEDOUTER = 0x0001;
        public const uint BDR_SUNKENOUTER = 0x0002;
        public const uint BDR_RAISEDINNER = 0x0004;
        public const uint BDR_SUNKENINNER = 0x0008;
        public const uint BDR_OUTER       = (BDR_RAISEDOUTER | BDR_SUNKENOUTER);
        public const uint BDR_INNER       = (BDR_RAISEDINNER | BDR_SUNKENINNER);
        public const uint BDR_RAISED      = (BDR_RAISEDOUTER | BDR_RAISEDINNER);
        public const uint BDR_SUNKEN      = (BDR_SUNKENOUTER | BDR_SUNKENINNER);
        public const uint EDGE_RAISED     = (BDR_RAISEDOUTER | BDR_RAISEDINNER);
        public const uint EDGE_SUNKEN     = (BDR_SUNKENOUTER | BDR_SUNKENINNER);
        public const uint EDGE_ETCHED     = (BDR_SUNKENOUTER | BDR_RAISEDINNER);
        public const uint EDGE_BUMP       = (BDR_RAISEDOUTER | BDR_SUNKENINNER);
        public const uint BF_LEFT         = 0x0001;
        public const uint BF_TOP          = 0x0002;
        public const uint BF_RIGHT        = 0x0004;
        public const uint BF_BOTTOM       = 0x0008;
        public const uint BF_TOPLEFT      = (BF_TOP | BF_LEFT);
        public const uint BF_TOPRIGHT     = (BF_TOP | BF_RIGHT);
        public const uint BF_BOTTOMLEFT   = (BF_BOTTOM | BF_LEFT);
        public const uint BF_BOTTOMRIGHT  = (BF_BOTTOM | BF_RIGHT);
        public const uint BF_RECT         = (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM);
        public const uint BF_DIAGONAL     = 0x0010;
        public const uint BF_DIAGONAL_ENDTOPRIGHT     = (BF_DIAGONAL | BF_TOP | BF_RIGHT);
        public const uint BF_DIAGONAL_ENDTOPLEFT      = (BF_DIAGONAL | BF_TOP | BF_LEFT);
        public const uint BF_DIAGONAL_ENDBOTTOMLEFT   = (BF_DIAGONAL | BF_BOTTOM | BF_LEFT);
        public const uint BF_DIAGONAL_ENDBOTTOMRIGHT  = (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT);
        public const uint BF_MIDDLE       = 0x0800;
        public const uint BF_SOFT         = 0x1000;
        public const uint BF_ADJUST       = 0x2000;
        public const uint BF_FLAT         = 0x4000;
        public const uint BF_MONO         = 0x8000;


		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsIconic(IntPtr hWnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool AdjustWindowRect(ref RECT lpRect, uint dwStyle, bool bMenu);

		[DllImport("user32.dll")]
		public static extern IntPtr GetMenu(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr hCursor);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        public const int IDC_ARROW = 32512;
        public const int IDC_IBEAM = 32513;
        public const int IDC_WAIT = 32514;
        public const int IDC_CROSS = 32515;
        public const int IDC_UPARROW = 32516;
        public const int IDC_SIZE = 32640;
        public const int IDC_ICON = 32641;
        public const int IDC_SIZENWSE = 32642;
        public const int IDC_SIZENESW = 32643;
        public const int IDC_SIZEWE = 32644;
        public const int IDC_SIZENS = 32645;
        public const int IDC_SIZEALL = 32646;
        public const int IDC_NO = 32648;
        public const int IDC_HAND = 32649;
        public const int IDC_APPSTARTING = 32650;
        public const int IDC_HELP = 32651;

		public const uint ACTCTX_PROCESSOR_ARCHITECTURE_VALID = 0x001;
		public const uint ACTCTX_LANGID_VALID = 0x002;
		public const uint ACTCTX_ASSEMBLY_DIRECTORY_VALID = 0x004;
		public const uint ACTCTX_RESOURCE_NAME_VALID = 0x008;
		public const uint ACTCTX_SET_PROCESS_DEFAULT = 0x010;
		public const uint ACTCTX_APPLICATION_NAME_VALID = 0x020;

		[StructLayout(LayoutKind.Sequential)]
		public struct ACTCTX
		{
			public int cbSize;
			public uint dwFlags;
			public string lpSource;
			public ushort wProcessorArchitecture;
			public ushort wLangId;
			public string lpAssemblyDirectory;
			public UInt16 lpResourceName;
			public string lpApplicationName;
		}

		[DllImport("Kernel32.dll", SetLastError = true)]
		public static extern IntPtr CreateActCtx(ref ACTCTX ctx);

		[DllImport("Kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ActivateActCtx(IntPtr hActCtx, out IntPtr lpCookie);

		[DllImport("Kernel32.dll", SetLastError = true)]
		public static extern void ReleaseActCtx(IntPtr hActCtx);

		[DllImport("Kernel32.dll", SetLastError = true)]
		public static extern void AddRefActCtx(IntPtr hActCtx);

		[DllImport("Kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeactivateActCtx(int dwFlags, IntPtr lpCookie);

		public struct INITCOMMONCONTROLSEX
		{
			private int dwSize;
			public uint dwICC;

			public INITCOMMONCONTROLSEX(uint dwICC=0)
				: this()
			{
				this.dwSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(INITCOMMONCONTROLSEX));
				this.dwICC = dwICC;
			}
		}

		[DllImport("comctl32.dll", EntryPoint = "InitCommonControlsEx", CallingConvention = CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InitCommonControlsEx(ref INITCOMMONCONTROLSEX iccex);

		public const int WHITE_BRUSH = 0;
		public const int LTGRAY_BRUSH = 1;
		public const int GRAY_BRUSH = 2;
		public const int DKGRAY_BRUSH = 3;
		public const int BLACK_BRUSH = 4;
		public const int NULL_BRUSH = 5;
		public const int HOLLOW_BRUSH = NULL_BRUSH;
		public const int WHITE_PEN = 6;
		public const int BLACK_PEN = 7;
		public const int NULL_PEN = 8;
		public const int OEM_FIXED_FONT = 10;
		public const int ANSI_FIXED_FONT = 11;
		public const int ANSI_VAR_FONT = 12;
		public const int SYSTEM_FONT = 13;
		public const int DEVICE_DEFAULT_FONT = 14;
		public const int DEFAULT_PALETTE = 15;
		public const int SYSTEM_FIXED_FONT = 16;
		public const int DEFAULT_GUI_FONT = 17;
		public const int DC_BRUSH = 18;
		public const int DC_PEN = 19;

		[DllImport("gdi32.dll")]
		public static extern IntPtr GetStockObject(int Object);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int options);

        [DllImport("gdi32.dll")]
		public static extern IntPtr CreateIC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpdvmInit);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, uint flags);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public const uint DCX_WINDOW = 0x00000001;
        public const uint DCX_CACHE = 0x00000002;
        public const uint DCX_NORESETATTRS = 0x00000004;
        public const uint DCX_CLIPCHILDREN = 0x00000008;
        public const uint DCX_CLIPSIBLINGS = 0x00000010;
        public const uint DCX_PARENTCLIP = 0x00000020;
        public const uint DCX_EXCLUDERGN = 0x00000040;
        public const uint DCX_INTERSECTRGN = 0x00000080;
        public const uint DCX_EXCLUDEUPDATE = 0x00000100;
        public const uint DCX_INTERSECTUPDATE = 0x00000200;
        public const uint DCX_LOCKWINDOWUPDATE = 0x00000400;
        public const uint DCX_VALIDATE = 0x00200000;

        public const uint IDI_ERROR = 32513;
        public const uint IDI_WARNING = 32515;
        public const uint IDI_QUESTION = 32514;
        public const uint IDI_INFORMATION = 32516;

        public const int IMAGE_BITMAP = 0;
        public const int IMAGE_ICON = 1;
        public const int IMAGE_CURSOR = 2;
        public const int IMAGE_ENHMETAFILE = 3;

        public const int LR_DEFAULTCOLOR = 0x0000;
        public const int LR_MONOCHROME = 0x0001;
        public const int LR_COPYRETURNORG = 0x0004;
        public const int LR_COPYDELETEORG = 0x0008;
        public const int LR_LOADFROMFILE = 0x0010;
        public const int LR_LOADTRANSPARENT = 0x0020;
        public const int LR_DEFAULTSIZE = 0x0040;
        public const int LR_VGACOLOR = 0x0080;
        public const int LR_LOADMAP3DCOLORS = 0x1000;
        public const int LR_CREATEDIBSECTION = 0x2000;
        public const int LR_COPYFROMRESOURCE = 0x4000;
        public const int LR_SHARED = 0x8000;

        [DllImport("user32.dll")]
        public static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr lpIconName);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadImage(IntPtr hinst, IntPtr lpszName, uint uType, int cxDesired, int cyDesired, uint fuLoad);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string moduleName);

        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC", SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC([In] IntPtr hdc);

        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
        public static extern IntPtr CreateCompatibleBitmap([In] IntPtr hdc, int nWidth, int nHeight);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDIBSection(IntPtr hdc, [In] ref BITMAPINFOHEADER pbmi, uint pila, out IntPtr ppvBits, IntPtr hSection, uint dwOffset);

        public const uint ILC_COLOR32 = 0x00000020;

        [DllImport("comctl32.dll", SetLastError = true)]
        public static extern IntPtr ImageList_Create(int cx, int cy, uint flags, int cInitial, int cGrow);

        [DllImport("comctl32.dll", SetLastError = true)]
        public static extern int ImageList_Add(IntPtr hImageList, IntPtr hBitmap, IntPtr hMask);

        [DllImport("Comctl32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ImageList_Destroy(IntPtr himl);

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFOHEADER
        {
            public Int32 biSize;
            public Int32 biWidth;
            public Int32 biHeight;
            public Int16 biPlanes;
            public Int16 biBitCount;
            public Int32 biCompression;
            public Int32 biSizeImage;
            public Int32 biXPelsPerMeter;
            public Int32 biYPelsPerMeter;
            public Int32 biClrUsed;
            public Int32 biClrImportant;
        }

        [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);

        [DllImport("gdi32.dll")]
        public static extern int GetObject(IntPtr hgdiobj, int cbBuffer, ref BITMAP bmp);

        [DllImport("gdi32.dll")]
        static extern int GetObject(IntPtr hgdiobj, int cbBuffer, out Win32.LOGFONT o);

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAP
        {
            public int bmType;
            public int bmWidth;
            public int bmHeight;
            public int bmWidthBytes;
            public int bmPlanes;
            public int bmBitsPixel;
            public IntPtr bmBits;
        }

        
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr hdc);

		[DllImport("gdi32.dll", ExactSpelling = true, PreserveSig = true, SetLastError = true)]
		public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);


        [DllImport("gdi32.dll")]
        public static extern int SetBkMode(IntPtr hdc, int iBkMode);

        public const int TRANSPARENT = 1;
        public const int OPAQUE = 2;

        [DllImport("gdi32.dll")]
        public static extern uint SetTextColor(IntPtr hdc, uint crColor);

        [DllImport("gdi32.dll")]
        public static extern uint SetBkColor(IntPtr hdc, uint crColor);

        [DllImport("user32.dll")]
        public static extern uint GetSysColor(int index);

        [DllImport("user32.dll")]
        public static extern IntPtr GetSysColorBrush(int index);

        public const int COLOR_SCROLLBAR = 0;
        public const int COLOR_BACKGROUND = 1;
        public const int COLOR_DESKTOP = 1;
        public const int COLOR_ACTIVECAPTION = 2;
        public const int COLOR_INACTIVECAPTION = 3;
        public const int COLOR_MENU = 4;
        public const int COLOR_WINDOW = 5;
        public const int COLOR_WINDOWFRAME = 6;
        public const int COLOR_MENUTEXT = 7;
        public const int COLOR_WINDOWTEXT = 8;
        public const int COLOR_CAPTIONTEXT = 9;
        public const int COLOR_ACTIVEBORDER = 10;
        public const int COLOR_INACTIVEBORDER = 11;
        public const int COLOR_APPWORKSPACE = 12;
        public const int COLOR_HIGHLIGHT = 13;
        public const int COLOR_HIGHLIGHTTEXT = 14;
        public const int COLOR_BTNFACE = 15;
        public const int COLOR_THREEDFACE = 15;
        public const int COLOR_BTNSHADOW = 16;
        public const int COLOR_THREEDSHADOW = 16;
        public const int COLOR_GRAYTEXT = 17;
        public const int COLOR_BTNTEXT = 18;
        public const int COLOR_INACTIVECAPTIONTEXT = 19;
        public const int COLOR_BTNHIGHLIGHT = 20;
        public const int COLOR_TREEDHIGHLIGHT = 20;
        public const int COLOR_THREEDHILIGHT = 20;
        public const int COLOR_BTNHILIGHT = 20;
        public const int COLOR_THREEDDKSHADOW = 21;
        public const int COLOR_THREEDLIGHT = 22;
        public const int COLOR_INFOTEXT = 23;
        public const int COLOR_INFOBK = 24;


        public const uint DT_TOP = 0x00000000;
		public const uint DT_LEFT = 0x00000000;
		public const uint DT_CENTER = 0x00000001;
		public const uint DT_RIGHT = 0x00000002;
		public const uint DT_VCENTER = 0x00000004;
		public const uint DT_BOTTOM = 0x00000008;
		public const uint DT_WORDBREAK = 0x00000010;
		public const uint DT_SINGLELINE = 0x00000020;
		public const uint DT_EXPANDTABS = 0x00000040;
		public const uint DT_TABSTOP = 0x00000080;
		public const uint DT_NOCLIP = 0x00000100;
		public const uint DT_EXTERNALLEADING = 0x00000200;
		public const uint DT_CALCRECT = 0x00000400;
		public const uint DT_NOPREFIX = 0x00000800;
		public const uint DT_INTERNAL = 0x00001000;
        public const uint DT_END_ELLIPSIS = 0x00080000;
        public const uint DT_WORD_ELLIPSIS = 0x00040000;
        public const uint DT_HIDE_PREFIX = 0x00100000;


		[DllImport("user32.dll", EntryPoint="DrawTextW")]
        public static extern int DrawText(IntPtr hDC, [MarshalAs(UnmanagedType.LPWStr)] string lpString, int nCount, ref RECT lpRect, uint uFormat);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern bool GetTextMetrics(IntPtr hdc, out TEXTMETRIC lptm);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct TEXTMETRIC
        {
            public int tmHeight;
            public int tmAscent;
            public int tmDescent;
            public int tmInternalLeading;
            public int tmExternalLeading;
            public int tmAveCharWidth;
            public int tmMaxCharWidth;
            public int tmWeight;
            public int tmOverhang;
            public int tmDigitizedAspectX;
            public int tmDigitizedAspectY;
            public char tmFirstChar;
            public char tmLastChar;
            public char tmDefaultChar;
            public char tmBreakChar;
            public byte tmItalic;
            public byte tmUnderlined;
            public byte tmStruckOut;
            public byte tmPitchAndFamily;
            public byte tmCharSet;
        }

        [DllImport("user32.dll")]
        public static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

        public static bool ScreenToClient(IntPtr hWnd, ref RECT lpRect)
        {
            POINT tl = lpRect.Location;
            POINT br = lpRect.BottomRight;
            ScreenToClient(hWnd, ref tl);
            ScreenToClient(hWnd, ref br);
            lpRect = new RECT(tl, br);
            return true;
        }

        public static bool ClientToScreen(IntPtr hWnd, ref RECT lpRect)
        {
            POINT tl = lpRect.Location;
            POINT br = lpRect.BottomRight;
            ClientToScreen(hWnd, ref tl);
            ClientToScreen(hWnd, ref br);
            lpRect = new RECT(tl, br);
            return true;
        }

        [DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetProp(IntPtr hWnd, string lpString, IntPtr hData);

		[DllImport("user32.dll")]
		public static extern IntPtr GetProp(IntPtr hWnd, string lpString);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowEnabled(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hWnd, [In] ref RECT lpRect, bool bErase);

        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hWnd, [In] IntPtr lpRect, bool bErase);

        [DllImport("user32.dll")]
        public static extern IntPtr DialogBoxIndirectParam(IntPtr hInstance, IntPtr lpTemplate, IntPtr hWndParent, WNDPROC lpDialogFunc, IntPtr dwInitParam);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateDialogIndirectParam(IntPtr hInstance, IntPtr lpTemplate, IntPtr hWndParent, WNDPROC lpDialogFunc, IntPtr dwInitParam);

        [DllImport("user32.dll")]
        public static extern int GetDlgCtrlID(IntPtr hwndCtl);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);
        
        [DllImport("user32.dll")]
        public static extern bool EndDialog(IntPtr hDlg, IntPtr nResult);

        [DllImport("user32.dll")]
        public static extern IntPtr BeginPaint(IntPtr hwnd, out PAINTSTRUCT lpPaint);

        [DllImport("user32.dll")]
        public static extern bool EndPaint(IntPtr hWnd, [In] ref PAINTSTRUCT lpPaint);

        [StructLayout(LayoutKind.Sequential)]
        public struct PAINTSTRUCT
        {
            public IntPtr hdc;
            public bool fErase;
            public RECT rcPaint;
            public bool fRestore;
            public bool fIncUpdate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] rgbReserved;
        }

        [DllImport("gdi32.dll")]
        public static extern bool LineTo(IntPtr hdc, int nXEnd, int nYEnd);

        [DllImport("gdi32.dll")]
        public static extern bool MoveToEx(IntPtr hdc, int X, int Y, IntPtr lpPoint);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreatePen(int PenStyle, int nWidth, uint crColor);

        public const int PS_SOLID = 0;

        [DllImport("user32.dll")]
        public static extern int FillRect(IntPtr hDC, [In] ref RECT lprc, IntPtr hbr);

        [DllImport("gdi32.dll")]
        public static extern bool Polygon(IntPtr hdc, POINT[] lpPoints, int nCount);

        [DllImport("gdi32.dll")]
        public static extern bool Rectangle(IntPtr hDC, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);


        [DllImport("gdi32.dll")]
        public static extern bool FillRgn(IntPtr hDC, IntPtr hrgn, IntPtr hbr);

        [DllImport("user32.dll")]
        public static extern int GetUpdateRgn(IntPtr hWnd, IntPtr hRgn, bool bErase);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateSolidBrush(uint crColor);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreatePatternBrush(IntPtr hbmp);


        public const uint GW_HWNDFIRST = 0;
        public const uint GW_HWNDLAST = 1;
        public const uint GW_HWNDNEXT = 2;
        public const uint GW_HWNDPREV = 3;
        public const uint GW_OWNER = 4;
        public const uint GW_CHILD = 5;
        public const uint GW_ENABLEDPOPUP = 6;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowScrollBar(IntPtr hWnd, int bar, [MarshalAs(UnmanagedType.Bool)] bool bShow);

        [DllImport("user32.dll")]
        public static extern int SetScrollPos(IntPtr hWnd, int bar, int nPos, bool bRedraw);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetScrollPos(IntPtr hWnd, int bar);

        [DllImport("user32.dll")]
        public static extern bool UpdateWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int ScrollWindowEx(IntPtr hWnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);

        public const uint SW_SCROLLCHILDREN = 0x0001;
        public const uint SW_INVALIDATE = 0x0002;
        public const uint SW_ERASE = 0x0004;
        public const uint SW_SMOOTHSCROLL = 0x0010;

        public const int SB_HORZ = 0;
        public const int SB_VERT = 1;
        public const int SB_CTL = 2;
        public const int SB_BOTH = 3;

        public const int SB_LINEUP           =0;
        public const int SB_LINELEFT         =0;
        public const int SB_LINEDOWN         =1;
        public const int SB_LINERIGHT        =1;
        public const int SB_PAGEUP           =2;
        public const int SB_PAGELEFT         =2;
        public const int SB_PAGEDOWN         =3;
        public const int SB_PAGERIGHT        =3;
        public const int SB_THUMBPOSITION    =4;
        public const int SB_THUMBTRACK       =5;
        public const int SB_TOP              =6;
        public const int SB_LEFT             =6;
        public const int SB_BOTTOM           =7;
        public const int SB_RIGHT            =7;
        public const int SB_ENDSCROLL        =8;

        [StructLayout(LayoutKind.Sequential)]
        public struct SCROLLINFO
        {
            public uint cbSize;
            public uint fMask;
            public int nMin;
            public int nMax;
            public uint nPage;
            public int nPos;
            public int nTrackPos;
        }

        public const uint SIF_RANGE           = 0x0001;
        public const uint SIF_PAGE            = 0x0002;
        public const uint SIF_POS             = 0x0004;
        public const uint SIF_DISABLENOSCROLL = 0x0008;
        public const uint SIF_TRACKPOS        = 0x0010;
        public const uint SIF_ALL = (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS);

        [DllImport("user32.dll")]
        public static extern int SetScrollInfo(IntPtr hwnd, int bar, [In] ref SCROLLINFO lpsi, bool fRedraw);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int smIndex);

        public const int SM_CXSCREEN             =0 ;
        public const int SM_CYSCREEN             =1 ;
        public const int SM_CXVSCROLL            =2 ;
        public const int SM_CYHSCROLL            =3 ;
        public const int SM_CYCAPTION            =4 ;
        public const int SM_CXBORDER             =5 ;
        public const int SM_CYBORDER             =6 ;
        public const int SM_CXDLGFRAME           =7 ;
        public const int SM_CYDLGFRAME           =8 ;
        public const int SM_CYVTHUMB             =9 ;
        public const int SM_CXHTHUMB             =10;
        public const int SM_CXICON               =11;
        public const int SM_CYICON               =12;
        public const int SM_CXCURSOR             =13;
        public const int SM_CYCURSOR             =14;
        public const int SM_CYMENU               =15;
        public const int SM_CXFULLSCREEN         =16;
        public const int SM_CYFULLSCREEN         =17;
        public const int SM_CYKANJIWINDOW        =18;
        public const int SM_MOUSEPRESENT         =19;
        public const int SM_CYVSCROLL            =20;
        public const int SM_CXHSCROLL            =21;
        public const int SM_DEBUG                =22;
        public const int SM_SWAPBUTTON           =23;
        public const int SM_RESERVED1            =24;
        public const int SM_RESERVED2            =25;
        public const int SM_RESERVED3            =26;
        public const int SM_RESERVED4            =27;
        public const int SM_CXMIN                =28;
        public const int SM_CYMIN                =29;
        public const int SM_CXSIZE               =30;
        public const int SM_CYSIZE               =31;
        public const int SM_CXFRAME              =32;
        public const int SM_CYFRAME              =33;
        public const int SM_CXMINTRACK           =34;
        public const int SM_CYMINTRACK           =35;
        public const int SM_CXDOUBLECLK          =36;
        public const int SM_CYDOUBLECLK          =37;
        public const int SM_CXICONSPACING        =38;
        public const int SM_CYICONSPACING        =39;
        public const int SM_MENUDROPALIGNMENT    =40;
        public const int SM_PENWINDOWS           =41;
        public const int SM_DBCSENABLED          =42;
        public const int SM_CMOUSEBUTTONS        =43;
        public const int SM_XVIRTUALSCREEN = 76;
        public const int SM_YVIRTUALSCREEN = 77;
        public const int SM_CXVIRTUALSCREEN = 78;
        public const int SM_CYVIRTUALSCREEN = 79;



        public const int MONITOR_DEFAULTTONULL = 0;
        public const int MONITOR_DEFAULTTOPRIMARY = 1;
        public const int MONITOR_DEFAULTTONEAREST = 2;

        [StructLayout(LayoutKind.Sequential)]
        public struct MONITORINFO
        {
            public int cbSize;
            public RECT rcMonitor;
            public RECT rcWork;
            public uint dwFlags;
        }

        [DllImport("user32.dll")]
        public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("gdi32.dll", EntryPoint="CreateFontIndirectW")]
        public static extern IntPtr CreateFontIndirect([In] ref LOGFONT lplf);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        [DllImport("user32.dll")]
        public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        [DllImport("gdi32.dll")]
        public static extern bool SetRectRgn(IntPtr hrgn, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreatePolygonRgn(POINT[] lppt, int cPoints, int fnPolyFillMode);

        [DllImport("gdi32.dll")]
        public static extern int CombineRgn(IntPtr hrgnDest, IntPtr hrgnSrc1, IntPtr hrgnSrc2, int fnCombineMode);

        public const int RGN_AND = 1;
        public const int RGN_OR = 2;
        public const int RGN_XOR = 3;
        public const int RGN_DIFF = 4;
        public const int RGN_COPY = 5;

        [DllImport("gdi32.dll")]
        public static extern int GetClipRgn(IntPtr hdc, IntPtr hrgn);

        [DllImport("gdi32.dll")]
        public static extern int IntersectClipRect(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        [DllImport("gdi32.dll")]
        public static extern int SelectClipRgn(IntPtr hdc, IntPtr hrgn);

        [DllImport("gdi32.dll", EntryPoint = "GdiAlphaBlend")]
        public static extern bool AlphaBlend(IntPtr hdcDest, int nXOriginDest, int nYOriginDest,
            int nWidthDest, int nHeightDest,
            IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc,
            BLENDFUNCTION blendFunction);

        [DllImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BitBlt([In] IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, 
                        [In] IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

        public const uint SRCCOPY = 0x00CC0020;

        [StructLayout(LayoutKind.Sequential)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;

            public BLENDFUNCTION(byte op, byte flags, byte alpha, byte format)
            {
                BlendOp = op;
                BlendFlags = flags;
                SourceConstantAlpha = alpha;
                AlphaFormat = format;
            }
        }

        //
        // currently defined blend operation
        //
        public const int AC_SRC_OVER = 0x00;

        //
        // currently defined alpha format
        //
        public const int AC_SRC_ALPHA = 0x01;


        [DllImport("user32.dll")]
        public static extern bool DeleteMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool InsertMenu(IntPtr hmenu, uint position, uint flags, IntPtr item_id, [MarshalAs(UnmanagedType.LPTStr)] string item_text);

        [DllImport("user32.dll")]
        public static extern uint CheckMenuItem(IntPtr hmenu, uint uIDCheckItem, uint uCheck);

        [DllImport("user32.dll")]
        public static extern uint EnableMenuItem(IntPtr hmenu, uint uIDCheckItem, uint uCheck);

        [DllImport("user32.dll")]
        public static extern IntPtr CreatePopupMenu();

        [DllImport("user32.dll")]
        public static extern IntPtr CreateMenu();

        [DllImport("user32.dll")]
        public static extern bool ModifyMenu(IntPtr hMnu, uint uPosition, uint uFlags, IntPtr uIDNewItem, string lpNewItem);

        [DllImport("user32.dll")]
        public static extern bool DestroyMenu(IntPtr hMenu);

        [DllImport("user32.dll")]
        public static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        [DllImport("user32.dll")]
        public static extern bool SetMenu(IntPtr hWnd, IntPtr hMenu);

        [DllImport("user32.dll")]
        public static extern bool TrackPopupMenuEx(IntPtr hmenu, uint fuFlags, int x, int y, IntPtr hwnd, IntPtr lptpm);

        [DllImport("user32.dll")]
        public static extern bool TrackPopupMenuEx(IntPtr hmenu, uint fuFlags, int x, int y, IntPtr hwnd, [In] ref TPMPARAMS lptpm);

        [StructLayout(LayoutKind.Sequential)]
        public struct TPMPARAMS
        {
            public uint size;
            public RECT rcExclude;
        }

        public const uint TPM_LEFTBUTTON      =0x0000;
        public const uint TPM_RIGHTBUTTON     =0x0002;
        public const uint TPM_LEFTALIGN       =0x0000;
        public const uint TPM_CENTERALIGN     =0x0004;
        public const uint TPM_RIGHTALIGN      =0x0008;
        public const uint TPM_TOPALIGN        =0x0000;
        public const uint TPM_VCENTERALIGN    =0x0010;
        public const uint TPM_BOTTOMALIGN     =0x0020;
        public const uint TPM_HORIZONTAL      =0x0000;     /* Horz alignment matters more */
        public const uint TPM_VERTICAL        =0x0040;     /* Vert alignment matters more */
        public const uint TPM_NONOTIFY        =0x0080;     /* Don't send any notification msgs */
        public const uint TPM_RETURNCMD       =0x0100;
        public const uint TPM_RECURSE         =0x0001;
        public const uint TPM_HORPOSANIMATION =0x0400;
        public const uint TPM_HORNEGANIMATION =0x0800;
        public const uint TPM_VERPOSANIMATION =0x1000;
        public const uint TPM_VERNEGANIMATION =0x2000;
        public const uint TPM_NOANIMATION     =0x4000;
        public const uint TPM_LAYOUTRTL       =0x8000;
        public const uint TPM_WORKAREA        =0x10000;

        [DllImport("uxtheme", ExactSpelling = true)]
        public extern static int IsThemeActive();

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
        
        [DllImport("uxtheme", ExactSpelling = true)]
        public extern static Int32 DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId,
           int iStateId, ref RECT pRect, ref RECT pClipRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public extern static Int32 DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId,
           int iStateId, ref RECT pRect, IntPtr pClipRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public extern static Int32 GetThemeBackgroundContentRect(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pBoundingRect, out RECT pContentRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public extern static Int32 DrawThemeEdge(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pDestRect, uint egde, uint flags, out RECT pRect);

        [DllImport("uxtheme", ExactSpelling = true)]
        public extern static Int32 DrawThemeEdge(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pDestRect, uint egde, uint flags, IntPtr pRect);

        [DllImport("uxtheme", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public extern static Int32 DrawThemeText(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, String text, int textLength, UInt32 textFlags, UInt32 textFlags2, ref RECT pRect);

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr OpenThemeData(IntPtr hWnd, String classList);

        [DllImport("uxtheme.dll", ExactSpelling = true)]
        public extern static Int32 CloseThemeData(IntPtr hTheme);

        public const int TP_BUTTON = 1;
        public const int TP_DROPDOWNBUTTON = 2;
        public const int TP_SPLITBUTTON = 3;
        public const int TP_SPLITBUTTONDROPDOWN = 4;
        public const int TP_SEPARATOR = 5;
        public const int TP_SEPARATORVERT = 6;
        public const int TP_DROPDOWNBUTTONGLYPH = 7;

        public const int TS_NORMAL = 1;
        public const int TS_HOT = 2;
        public const int TS_PRESSED = 3;
        public const int TS_DISABLED = 4;
        public const int TS_CHECKED = 5;
        public const int TS_HOTCHECKED = 6;
        public const int TS_NEARHOT = 7;
        public const int TS_OTHERSIDEHOT = 8;


        [DllImport("gdi32.dll", EntryPoint = "GdiGradientFill", ExactSpelling = true)]
        public static extern bool GradientFill(
            IntPtr hdc,           // handle to DC
            IntPtr pVertex,    // array of vertices
            uint dwNumVertex,     // number of vertices
            [In] ref GRADIENT_RECT pMesh,           // array of gradients
            uint dwNumMesh,       // size of gradient array
            uint dwMode);           // gradient fill mode);

        [DllImport("gdi32.dll", EntryPoint = "GdiGradientFill", ExactSpelling = true)]
        public static extern bool GradientFill(
            IntPtr hdc,           // handle to DC
            IntPtr pVertex,    // array of vertices
            uint dwNumVertex,     // number of vertices
            [In] ref GRADIENT_TRIANGLE pMesh,           // array of gradients
            uint dwNumMesh,       // size of gradient array
            uint dwMode);           // gradient fill mode);

        public const uint GRADIENT_FILL_RECT_H = 0x00000000;
        public const uint GRADIENT_FILL_RECT_V = 0x00000001;
        public const uint GRADIENT_FILL_TRIANGLE = 0x00000002;
        public const uint GRADIENT_FILL_OP_FLAG = 0x000000ff;


        [StructLayout(LayoutKind.Sequential)]
        public struct GRADIENT_RECT
        {
            public uint UpperLeft;
            public uint LowerRight;

            public GRADIENT_RECT(uint upLeft, uint lowRight)
            {
                UpperLeft = upLeft;
                LowerRight = lowRight;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GRADIENT_TRIANGLE
        {
            uint Vertex1;
            uint Vertex2;
            uint Vertex3;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct TRIVERTEX
        {
            public int x;
            public int y;
            public ushort Red;
            public ushort Green;
            public ushort Blue;
            public ushort Alpha;

            public TRIVERTEX(int x, int y, ushort red, ushort green, ushort blue, ushort alpha)
            {
                this.x = x;
                this.y = x;
                this.Red = red;
                this.Green = green;
                this.Blue = blue;
                this.Alpha = alpha;
            }
        }


        public const uint MF_BYCOMMAND = 0x00000000;
        public const uint MF_BYPOSITION = 0x00000400;
        public const uint MF_SEPARATOR = 0x00000800;
        public const uint MF_ENABLED = 0x00000000;
        public const uint MF_GRAYED = 0x00000001;
        public const uint MF_DISABLED = 0x00000002;
        public const uint MF_UNCHECKED = 0x00000000;
        public const uint MF_CHECKED = 0x00000008;
        public const uint MF_USECHECKBITMAPS = 0x00000200;
        public const uint MF_STRING = 0x00000000;
        public const uint MF_BITMAP = 0x00000004;
        public const uint MF_OWNERDRAW = 0x00000100;
        public const uint MF_POPUP = 0x00000010;
        public const uint MF_MENUBARBREAK = 0x00000020;
        public const uint MF_MENUBREAK = 0x00000040;
        public const uint MF_UNHILITE = 0x00000000;
        public const uint MF_HILITE = 0x00000080;

        public const int DRIVERVERSION   = 0  ;
        public const int TECHNOLOGY      = 2  ;
        public const int HORZSIZE        = 4  ;
        public const int VERTSIZE        = 6  ;
        public const int HORZRES         = 8  ;
        public const int VERTRES         = 10 ;
        public const int BITSPIXEL       = 12 ;
        public const int PLANES          = 14 ;
        public const int NUMBRUSHES      = 16 ;
        public const int NUMPENS         = 18 ;
        public const int NUMMARKERS      = 20 ;
        public const int NUMFONTS        = 22 ;
        public const int NUMCOLORS       = 24 ;
        public const int PDEVICESIZE     = 26 ;
        public const int CURVECAPS       = 28 ;
        public const int LINECAPS        = 30 ;
        public const int POLYGONALCAPS   = 32 ;
        public const int TEXTCAPS        = 34 ;
        public const int CLIPCAPS        = 36 ;
        public const int RASTERCAPS      = 38 ;
        public const int ASPECTX         = 40 ;
        public const int ASPECTY         = 42 ;
        public const int ASPECTXY        = 44 ;
        public const int LOGPIXELSX      = 88 ;
        public const int LOGPIXELSY      = 90 ;
        public const int SIZEPALETTE     = 104;
        public const int NUMRESERVED     = 106;
        public const int COLORRES        = 108;
        public const int PHYSICALWIDTH   = 110; 
        public const int PHYSICALHEIGHT  = 111; 
        public const int PHYSICALOFFSETX = 112; 
        public const int PHYSICALOFFSETY = 113; 
        public const int SCALINGFACTORX  = 114; 
        public const int SCALINGFACTORY  = 115; 
        public const int VREFRESH        = 116;
        public const int DESKTOPVERTRES  = 117;
        public const int DESKTOPHORZRES  = 118;
        public const int BLTALIGNMENT    = 119;
        public const int SHADEBLENDCAPS  = 120;
        public const int COLORMGMTCAPS   = 121;

        public struct NONCLIENTMETRICS
        {
            public int cbSize;
            public int iBorderWidth;
            public int iScrollWidth;
            public int iScrollHeight;
            public int iCaptionWidth;
            public int iCaptionHeight;
            public LOGFONT lfCaptionFont;
            public int iSmCaptionWidth;
            public int iSmCaptionHeight;
            public LOGFONT lfSmCaptionFont;
            public int iMenuWidth;
            public int iMenuHeight;
            public LOGFONT lfMenuFont;
            public LOGFONT lfStatusFont;
            public LOGFONT lfMessageFont;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct LOGFONT
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string lfFaceName;
        }

        public const uint SPIF_UPDATEINIFILE = 0x0001;
        public const uint SPIF_SENDCHANGE = 0x0002;

        public const uint SPI_GETBEEP = 0x0001;
        public const uint SPI_SETBEEP = 0x0002;
        public const uint SPI_GETMOUSE = 0x0003;
        public const uint SPI_SETMOUSE = 0x0004;
        public const uint SPI_GETBORDER = 0x0005;
        public const uint SPI_SETBORDER = 0x0006;
        public const uint SPI_GETKEYBOARDSPEED = 0x000A;
        public const uint SPI_SETKEYBOARDSPEED = 0x000B;
        public const uint SPI_LANGDRIVER = 0x000C;
        public const uint SPI_ICONHORIZONTALSPACING = 0x000D;
        public const uint SPI_GETSCREENSAVETIMEOUT = 0x000E;
        public const uint SPI_SETSCREENSAVETIMEOUT = 0x000F;
        public const uint SPI_GETSCREENSAVEACTIVE = 0x0010;
        public const uint SPI_SETSCREENSAVEACTIVE = 0x0011;
        public const uint SPI_GETGRIDGRANULARITY = 0x0012;
        public const uint SPI_SETGRIDGRANULARITY = 0x0013;
        public const uint SPI_SETDESKWALLPAPER = 0x0014;
        public const uint SPI_SETDESKPATTERN = 0x0015;
        public const uint SPI_GETKEYBOARDDELAY = 0x0016;
        public const uint SPI_SETKEYBOARDDELAY = 0x0017;
        public const uint SPI_ICONVERTICALSPACING = 0x0018;
        public const uint SPI_GETICONTITLEWRAP = 0x0019;
        public const uint SPI_SETICONTITLEWRAP = 0x001A;
        public const uint SPI_GETMENUDROPALIGNMENT = 0x001B;
        public const uint SPI_SETMENUDROPALIGNMENT = 0x001C;
        public const uint SPI_SETDOUBLECLKWIDTH = 0x001D;
        public const uint SPI_SETDOUBLECLKHEIGHT = 0x001E;
        public const uint SPI_GETICONTITLELOGFONT = 0x001F;
        public const uint SPI_SETDOUBLECLICKTIME = 0x0020;
        public const uint SPI_SETMOUSEBUTTONSWAP = 0x0021;
        public const uint SPI_SETICONTITLELOGFONT = 0x0022;
        public const uint SPI_GETFASTTASKSWITCH = 0x0023;
        public const uint SPI_SETFASTTASKSWITCH = 0x0024;
        public const uint SPI_SETDRAGFULLWINDOWS = 0x0025;
        public const uint SPI_GETDRAGFULLWINDOWS = 0x0026;
        public const uint SPI_GETNONCLIENTMETRICS = 0x0029;
        public const uint SPI_SETNONCLIENTMETRICS = 0x002A;
        public const uint SPI_GETMINIMIZEDMETRICS = 0x002B;
        public const uint SPI_SETMINIMIZEDMETRICS = 0x002C;
        public const uint SPI_GETICONMETRICS = 0x002D;
        public const uint SPI_SETICONMETRICS = 0x002E;
        public const uint SPI_SETWORKAREA = 0x002F;
        public const uint SPI_GETWORKAREA = 0x0030;
        public const uint SPI_SETPENWINDOWS = 0x0031;
        public const uint SPI_GETHIGHCONTRAST = 0x0042;
        public const uint SPI_SETHIGHCONTRAST = 0x0043;
        public const uint SPI_GETKEYBOARDPREF = 0x0044;
        public const uint SPI_SETKEYBOARDPREF = 0x0045;
        public const uint SPI_GETSCREENREADER = 0x0046;
        public const uint SPI_SETSCREENREADER = 0x0047;
        public const uint SPI_GETANIMATION = 0x0048;
        public const uint SPI_SETANIMATION = 0x0049;
        public const uint SPI_GETFONTSMOOTHING = 0x004A;
        public const uint SPI_SETFONTSMOOTHING = 0x004B;
        public const uint SPI_SETDRAGWIDTH = 0x004C;
        public const uint SPI_SETDRAGHEIGHT = 0x004D;
        public const uint SPI_SETHANDHELD = 0x004E;
        public const uint SPI_GETLOWPOWERTIMEOUT = 0x004F;
        public const uint SPI_GETPOWEROFFTIMEOUT = 0x0050;
        public const uint SPI_SETLOWPOWERTIMEOUT = 0x0051;
        public const uint SPI_SETPOWEROFFTIMEOUT = 0x0052;
        public const uint SPI_GETLOWPOWERACTIVE = 0x0053;
        public const uint SPI_GETPOWEROFFACTIVE = 0x0054;
        public const uint SPI_SETLOWPOWERACTIVE = 0x0055;
        public const uint SPI_SETPOWEROFFACTIVE = 0x0056;
        public const uint SPI_SETCURSORS = 0x0057;
        public const uint SPI_SETICONS = 0x0058;
        public const uint SPI_GETDEFAULTINPUTLANG = 0x0059;
        public const uint SPI_SETDEFAULTINPUTLANG = 0x005A;
        public const uint SPI_SETLANGTOGGLE = 0x005B;
        public const uint SPI_GETWINDOWSEXTENSION = 0x005C;
        public const uint SPI_SETMOUSETRAILS = 0x005D;
        public const uint SPI_GETMOUSETRAILS = 0x005E;
        public const uint SPI_SETSCREENSAVERRUNNING = 0x0061;
        public const uint SPI_GETFILTERKEYS = 0x0032;
        public const uint SPI_SETFILTERKEYS = 0x0033;
        public const uint SPI_GETTOGGLEKEYS = 0x0034;
        public const uint SPI_SETTOGGLEKEYS = 0x0035;
        public const uint SPI_GETMOUSEKEYS = 0x0036;
        public const uint SPI_SETMOUSEKEYS = 0x0037;
        public const uint SPI_GETSHOWSOUNDS = 0x0038;
        public const uint SPI_SETSHOWSOUNDS = 0x0039;
        public const uint SPI_GETSTICKYKEYS = 0x003A;
        public const uint SPI_SETSTICKYKEYS = 0x003B;
        public const uint SPI_GETACCESSTIMEOUT = 0x003C;
        public const uint SPI_SETACCESSTIMEOUT = 0x003D;
        public const uint SPI_GETSERIALKEYS = 0x003E;
        public const uint SPI_SETSERIALKEYS = 0x003F;
        public const uint SPI_GETSOUNDSENTRY = 0x0040;
        public const uint SPI_SETSOUNDSENTRY = 0x0041;
        public const uint SPI_GETSNAPTODEFBUTTON = 0x005F;
        public const uint SPI_SETSNAPTODEFBUTTON = 0x0060;
        public const uint SPI_GETMOUSEHOVERWIDTH = 0x0062;
        public const uint SPI_SETMOUSEHOVERWIDTH = 0x0063;
        public const uint SPI_GETMOUSEHOVERHEIGHT = 0x0064;
        public const uint SPI_SETMOUSEHOVERHEIGHT = 0x0065;
        public const uint SPI_GETMOUSEHOVERTIME = 0x0066;
        public const uint SPI_SETMOUSEHOVERTIME = 0x0067;
        public const uint SPI_GETWHEELSCROLLLINES = 0x0068;
        public const uint SPI_SETWHEELSCROLLLINES = 0x0069;
        public const uint SPI_GETMENUSHOWDELAY = 0x006A;
        public const uint SPI_SETMENUSHOWDELAY = 0x006B;
        public const uint SPI_GETWHEELSCROLLCHARS = 0x006C;
        public const uint SPI_SETWHEELSCROLLCHARS = 0x006D;
        public const uint SPI_GETSHOWIMEUI = 0x006E;
        public const uint SPI_SETSHOWIMEUI = 0x006F;
        public const uint SPI_GETMOUSESPEED = 0x0070;
        public const uint SPI_SETMOUSESPEED = 0x0071;
        public const uint SPI_GETSCREENSAVERRUNNING = 0x0072;
        public const uint SPI_GETDESKWALLPAPER = 0x0073;
        public const uint SPI_GETAUDIODESCRIPTION = 0x0074;
        public const uint SPI_SETAUDIODESCRIPTION = 0x0075;
        public const uint SPI_GETSCREENSAVESECURE = 0x0076;
        public const uint SPI_SETSCREENSAVESECURE = 0x0077;
        public const uint SPI_GETHUNGAPPTIMEOUT = 0x0078;
        public const uint SPI_SETHUNGAPPTIMEOUT = 0x0079;
        public const uint SPI_GETWAITTOKILLTIMEOUT = 0x007A;
        public const uint SPI_SETWAITTOKILLTIMEOUT = 0x007B;
        public const uint SPI_GETWAITTOKILLSERVICETIMEOUT = 0x007C;
        public const uint SPI_SETWAITTOKILLSERVICETIMEOUT = 0x007D;
        public const uint SPI_GETMOUSEDOCKTHRESHOLD = 0x007E;
        public const uint SPI_SETMOUSEDOCKTHRESHOLD = 0x007F;
        public const uint SPI_GETPENDOCKTHRESHOLD = 0x0080;
        public const uint SPI_SETPENDOCKTHRESHOLD = 0x0081;
        public const uint SPI_GETWINARRANGING = 0x0082;
        public const uint SPI_SETWINARRANGING = 0x0083;
        public const uint SPI_GETMOUSEDRAGOUTTHRESHOLD = 0x0084;
        public const uint SPI_SETMOUSEDRAGOUTTHRESHOLD = 0x0085;
        public const uint SPI_GETPENDRAGOUTTHRESHOLD = 0x0086;
        public const uint SPI_SETPENDRAGOUTTHRESHOLD = 0x0087;
        public const uint SPI_GETMOUSESIDEMOVETHRESHOLD = 0x0088;
        public const uint SPI_SETMOUSESIDEMOVETHRESHOLD = 0x0089;
        public const uint SPI_GETPENSIDEMOVETHRESHOLD = 0x008A;
        public const uint SPI_SETPENSIDEMOVETHRESHOLD = 0x008B;
        public const uint SPI_GETDRAGFROMMAXIMIZE = 0x008C;
        public const uint SPI_SETDRAGFROMMAXIMIZE = 0x008D;
        public const uint SPI_GETSNAPSIZING = 0x008E;
        public const uint SPI_SETSNAPSIZING = 0x008F;
        public const uint SPI_GETDOCKMOVING = 0x0090;
        public const uint SPI_SETDOCKMOVING = 0x0091;
        public const uint SPI_GETACTIVEWINDOWTRACKING = 0x1000;
        public const uint SPI_SETACTIVEWINDOWTRACKING = 0x1001;
        public const uint SPI_GETMENUANIMATION = 0x1002;
        public const uint SPI_SETMENUANIMATION = 0x1003;
        public const uint SPI_GETCOMBOBOXANIMATION = 0x1004;
        public const uint SPI_SETCOMBOBOXANIMATION = 0x1005;
        public const uint SPI_GETLISTBOXSMOOTHSCROLLING = 0x1006;
        public const uint SPI_SETLISTBOXSMOOTHSCROLLING = 0x1007;
        public const uint SPI_GETGRADIENTCAPTIONS = 0x1008;
        public const uint SPI_SETGRADIENTCAPTIONS = 0x1009;
        public const uint SPI_GETKEYBOARDCUES = 0x100A;
        public const uint SPI_SETKEYBOARDCUES = 0x100B;
        public const uint SPI_GETACTIVEWNDTRKZORDER = 0x100C;
        public const uint SPI_SETACTIVEWNDTRKZORDER = 0x100D;
        public const uint SPI_GETHOTTRACKING = 0x100E;
        public const uint SPI_SETHOTTRACKING = 0x100F;
        public const uint SPI_GETMENUFADE = 0x1012;
        public const uint SPI_SETMENUFADE = 0x1013;
        public const uint SPI_GETSELECTIONFADE = 0x1014;
        public const uint SPI_SETSELECTIONFADE = 0x1015;
        public const uint SPI_GETTOOLTIPANIMATION = 0x1016;
        public const uint SPI_SETTOOLTIPANIMATION = 0x1017;
        public const uint SPI_GETTOOLTIPFADE = 0x1018;
        public const uint SPI_SETTOOLTIPFADE = 0x1019;
        public const uint SPI_GETCURSORSHADOW = 0x101A;
        public const uint SPI_SETCURSORSHADOW = 0x101B;
        public const uint SPI_GETMOUSESONAR = 0x101C;
        public const uint SPI_SETMOUSESONAR = 0x101D;
        public const uint SPI_GETMOUSECLICKLOCK = 0x101E;
        public const uint SPI_SETMOUSECLICKLOCK = 0x101F;
        public const uint SPI_GETMOUSEVANISH = 0x1020;
        public const uint SPI_SETMOUSEVANISH = 0x1021;
        public const uint SPI_GETFLATMENU = 0x1022;
        public const uint SPI_SETFLATMENU = 0x1023;
        public const uint SPI_GETDROPSHADOW = 0x1024;
        public const uint SPI_SETDROPSHADOW = 0x1025;
        public const uint SPI_GETBLOCKSENDINPUTRESETS = 0x1026;
        public const uint SPI_SETBLOCKSENDINPUTRESETS = 0x1027;
        public const uint SPI_GETUIEFFECTS = 0x103E;
        public const uint SPI_SETUIEFFECTS = 0x103F;
        public const uint SPI_GETDISABLEOVERLAPPEDCONTENT = 0x1040;
        public const uint SPI_SETDISABLEOVERLAPPEDCONTENT = 0x1041;
        public const uint SPI_GETCLIENTAREAANIMATION = 0x1042;
        public const uint SPI_SETCLIENTAREAANIMATION = 0x1043;
        public const uint SPI_GETCLEARTYPE = 0x1048;
        public const uint SPI_SETCLEARTYPE = 0x1049;
        public const uint SPI_GETSPEECHRECOGNITION = 0x104A;
        public const uint SPI_SETSPEECHRECOGNITION = 0x104B;
        public const uint SPI_GETFOREGROUNDLOCKTIMEOUT = 0x2000;
        public const uint SPI_SETFOREGROUNDLOCKTIMEOUT = 0x2001;
        public const uint SPI_GETACTIVEWNDTRKTIMEOUT = 0x2002;
        public const uint SPI_SETACTIVEWNDTRKTIMEOUT = 0x2003;
        public const uint SPI_GETFOREGROUNDFLASHCOUNT = 0x2004;
        public const uint SPI_SETFOREGROUNDFLASHCOUNT = 0x2005;
        public const uint SPI_GETCARETWIDTH = 0x2006;
        public const uint SPI_SETCARETWIDTH = 0x2007;
        public const uint SPI_GETMOUSECLICKLOCKTIME = 0x2008;
        public const uint SPI_SETMOUSECLICKLOCKTIME = 0x2009;
        public const uint SPI_GETFONTSMOOTHINGTYPE = 0x200A;
        public const uint SPI_SETFONTSMOOTHINGTYPE = 0x200B;
        public const uint SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;
        public const uint SPI_SETFONTSMOOTHINGCONTRAST = 0x200D;
        public const uint SPI_GETFOCUSBORDERWIDTH = 0x200E;
        public const uint SPI_SETFOCUSBORDERWIDTH = 0x200F;
        public const uint SPI_GETFOCUSBORDERHEIGHT = 0x2010;
        public const uint SPI_SETFOCUSBORDERHEIGHT = 0x2011;
        public const uint SPI_GETFONTSMOOTHINGORIENTATION = 0x2012;
        public const uint SPI_SETFONTSMOOTHINGORIENTATION = 0x2013;
        public const uint SPI_GETMINIMUMHITRADIUS = 0x2014;
        public const uint SPI_SETMINIMUMHITRADIUS = 0x2015;
        public const uint SPI_GETMESSAGEDURATION = 0x2016;
        public const uint SPI_SETMESSAGEDURATION = 0x2017;


        [StructLayout(LayoutKind.Sequential)]
        public struct SIZE
        {
            public int Width;
            public int Height;

            public SIZE(int Width, int Height)
            {
                this.Width = Width;
                this.Height = Height;
            }

            public static SIZE operator +(SIZE a, SIZE b)
            {
                return new SIZE(a.Width + b.Width, a.Height + b.Height);
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (!(obj is Win32.SIZE))
                    return false;

                return this == (Win32.SIZE)obj;
            }

            public override int GetHashCode()
            {
                return Width.GetHashCode() ^ Height.GetHashCode();
            }

            public static bool operator ==(SIZE a, SIZE b)
            {
                return a.Width == b.Width && a.Height == b.Height;
            }

            public static bool operator !=(SIZE a, SIZE b)
            {
                return !(a == b);
            }

        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            private int _Left;
            private int _Top;
            private int _Right;
            private int _Bottom;

            public RECT(RECT r)
                : this(r.Left, r.Top, r.Right, r.Bottom)
            {
            }
            public RECT(int Left, int Top, int Right, int Bottom)
            {
                _Left = Left;
                _Top = Top;
                _Right = Right;
                _Bottom = Bottom;
            }
            public RECT(POINT Origin, SIZE size)
            {
                _Left = Origin.X;
                _Top = Origin.Y;
                _Right = _Left + size.Width;
                _Bottom = _Top + size.Height;
            }

            public RECT(POINT Origin, POINT BottomRight)
            {
                _Left = Origin.X;
                _Top = Origin.Y;
                _Right = BottomRight.X;
                _Bottom = BottomRight.Y;
            }

            public int X
            {
                get { return _Left; }
                set { _Left = value; }
            }
            public int Y
            {
                get { return _Top; }
                set { _Top = value; }
            }
            public int Left
            {
                get { return _Left; }
                set { _Left = value; }
            }
            public int Top
            {
                get { return _Top; }
                set { _Top = value; }
            }
            public int Right
            {
                get { return _Right; }
                set { _Right = value; }
            }
            public int Bottom
            {
                get { return _Bottom; }
                set { _Bottom = value; }
            }
            public int Height
            {
                get { return _Bottom - _Top; }
                set { _Bottom = value + _Top; }
            }
            public int Width
            {
                get { return _Right - _Left; }
                set { _Right = value + _Left; }
            }
            public POINT Location
            {
                get { return new POINT(Left, Top); }
                set
                {
                    _Right = value.X + Width;
                    _Bottom = value.Y + Height;
                    _Left = value.X;
                    _Top = value.Y;
                }
            }
            public POINT BottomRight
            {
                get
                {
                    return new POINT(Right, Bottom);
                }
            }
            public SIZE Size
            {
                get { return new SIZE(Width, Height); }
                set
                {
                    _Right = value.Width + _Left;
                    _Bottom = value.Height + _Top;
                }
            }

            public POINT Center
            {
                get { return new POINT((_Left + _Right) / 2, (_Top + _Bottom) / 2); }
            }

            public bool Contains(Win32.RECT other)
            {
                return other.Left >= Left && other.Right <= Right && other.Top >= Top && other.Bottom <= Bottom;
            }

            public bool Intersects(Win32.RECT other)
            {
                Win32.RECT tmp;
                return Win32.IntersectRect(out tmp, ref this, ref other);
            }

            public static bool operator ==(RECT Rectangle1, RECT Rectangle2)
            {
                return Rectangle1.Equals(Rectangle2);
            }
            public static bool operator !=(RECT Rectangle1, RECT Rectangle2)
            {
                return !Rectangle1.Equals(Rectangle2);
            }

            public override string ToString()
            {
                return "{Left: " + _Left + "; " + "Top: " + _Top + "; Right: " + _Right + "; Bottom: " + _Bottom + "}";
            }

            public override int GetHashCode()
            {
                return ToString().GetHashCode();
            }

            public bool Equals(RECT Rectangle)
            {
                return Rectangle.Left == _Left && Rectangle.Top == _Top && Rectangle.Right == _Right && Rectangle.Bottom == _Bottom;
            }

            public override bool Equals(object Object)
            {
                if (Object is RECT)
                {
                    return Equals((RECT)Object);
                }

                return false;
            }

            public static RECT operator +(RECT r, POINT offset)
            {
                return new RECT(r.Location + offset, r.Size);
            }

            public void Offset(int dx, int dy)
            {
                _Left += dx;
                _Right += dx;
                _Top += dy;
                _Bottom += dy;
            }

        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static POINT operator +(POINT a, POINT b)
            {
                return new POINT(a.X + b.X, a.Y + b.Y);
            }

            public static POINT FromLParam(IntPtr lParam)
            {
                uint lp = (uint)lParam.ToInt32();
                return new POINT((int)(short)(lp & 0xFFFF), (int)(short)(lp >> 16));
            }

        }

    }

}
