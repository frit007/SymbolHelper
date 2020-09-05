using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SymbolHelper {
    [StructLayout(LayoutKind.Sequential)]    // Required by user32.dll
    public struct RECT {
        public uint Left;
        public uint Top;
        public uint Right;
        public uint Bottom;
    };

    [StructLayout(LayoutKind.Sequential)]    // Required by user32.dll
    public struct GUITHREADINFO {
        public uint cbSize;
        public uint flags;
        public IntPtr hwndActive;
        public IntPtr hwndFocus;
        public IntPtr hwndCapture;
        public IntPtr hwndMenuOwner;
        public IntPtr hwndMoveSize;
        public IntPtr hwndCaret;
        public RECT rcCaret;
    };
}
