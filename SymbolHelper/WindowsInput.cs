using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SymbolHelper {
    
        [StructLayout(LayoutKind.Sequential)]    // Required by user32.dll
        public struct KeyboardInput {
            public uint type; // 4
            public short wVk; // 2
            public short wScan; // 2
            public int dwFlags; // 
            public uint time;
            public uint dwExtraInfo;
        }
    //INPUT, * PINPUT, * LPINPUT;

}
