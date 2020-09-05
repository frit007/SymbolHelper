using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using System.Drawing;
using System.Runtime.CompilerServices;
using IWshRuntimeLibrary;
using SymbolHelper.Storage;

namespace SymbolHelper {
    class KeyHandler {
        // Virtual keycodes
        // http://www.kbdedit.com/manual/low_level_vk_list.html
        private const int VK_KEY_C = 0x43;
        private const int VK_LSHIFT = 0xA0;
        private const int VK_LCONTROL = 0xA2;
        private const int VK_KEY_LEFT = 0x25;

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static LowLevelKeyboardProc keyboardProc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static bool isWindowsPressed = false;
        private static int WINDOWS_KEY_LEFT = 0x0093edc4;

        private static Thread listenerThread;
        public static InputSimulator inputSimulator = new InputSimulator();
        private static Action<String> onCombination;
        private static Action<Action> runOnGui;
        private static Stopwatch sw = new Stopwatch();


        public static void Start(Action<String> onCombination, Action<Action> runOnGui) {
            KeyHandler.runOnGui = runOnGui;
            KeyHandler.onCombination = onCombination;
            listenerThread = new Thread(() => {
                _hookID = SetHook(keyboardProc);
                Application.Run();
                UnhookWindowsHookEx(_hookID);
            });
            listenerThread.Start();
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc) {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule) {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        // hide window before calling
        public static void sendString(string output) {
            new Thread(() => {
                SendKeys.SendWait(output);
            }).Start();
        }

        public static GUITHREADINFO GetCaretPosition() {
            GUITHREADINFO guiInfo = new GUITHREADINFO();
            guiInfo.cbSize = (uint)Marshal.SizeOf(guiInfo);

            // Get GuiThreadInfo into guiInfo
            GetGUIThreadInfo(0, out guiInfo);
            return guiInfo;
        }

        /// <summary>
        /// Retrieves name of active Process.
        /// </summary>
        /// <returns>Active Process Name</returns>
        private static string GetActiveProcess() {
            const int nChars = 256;
            int handle = 0;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = (int)GetForegroundWindow();

            // If Active window has some title info
            if (GetWindowText(handle, Buff, nChars) > 0) {
                uint lpdwProcessId;
                uint dwCaretID = GetWindowThreadProcessId(handle, out lpdwProcessId);
                uint dwCurrentID = (uint)Thread.CurrentThread.ManagedThreadId;
                return Process.GetProcessById((int)lpdwProcessId).ProcessName;
            }
            // Otherwise either error or non client region
            return String.Empty;
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);


        public static IDictionary<string, object> GetClipboardData() {
            var dict = new Dictionary<string, object>();
            var dataObject = Clipboard.GetDataObject();
            foreach (var format in dataObject.GetFormats(false)) {
                dict.Add(format, dataObject.GetData(format, false));
            }
            return dict;
        }

        public static void SetClipboardData(IDictionary<string, object> dict) {
            //var dataObject = Clipboard.GetDataObject();
            var dataObject = new DataObject();
            foreach (var kvp in dict) {
                dataObject.SetData(kvp.Key, kvp.Value);
            }
            //This might be unnecessary
            Clipboard.SetDataObject(dataObject);
        }

        private static string GetLastWord(Action<String> result) {
            runOnGui(() => {
                //var oldClipboardData = Clipboard.GetDataObject();
                var oldClipboardData = GetClipboardData();
                Thread s = new Thread(() => {
                    if (isWindowsPressed) {
                        inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);
                    }


                    sw.Start();
                    inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SHIFT);
                    inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.CONTROL);
                    inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LEFT);
                    inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LEFT);

                    inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SHIFT);


                    inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_C);
                    inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_C);

                    inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.CONTROL);
                    
                    sw.Stop();
                    Thread.Sleep(40);

                    runOnGui(() => {
                        string lastWord = Clipboard.GetText();
                        Console.WriteLine($"perf: {sw.Elapsed} ms");
                        for (int i = 0; i < 5; i++) {
                            try {
                                SetClipboardData(oldClipboardData);
                                break;
                            } catch (Exception) {
                                Console.WriteLine("failed to update clipboard");
                            }
                        }

                        new Thread(() => {
                            result(lastWord);
                        }).Start();
                    });
                });
                s.Start();
            });
            return "";
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            int vkCode = Marshal.ReadInt32(lParam);
            Keys key = (Keys)vkCode;
            bool isKeyDown = (IntPtr)WM_KEYDOWN == wParam;
            if (key == Keys.LWin) {
                isWindowsPressed = isKeyDown;
            }
            if(isWindowsPressed && key == Keys.J && isKeyDown) {
                //inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);
                //inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RWIN);
                //Thread.Sleep(100);
                //SendKeys.SendWait("Hello");

                //inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);

                if (SettingsStorage.getInstance().getSettings().SelectWordInOriginalProgram) {
                    GetLastWord((lastWord) => {
                        runOnGui(() => {
                            onCombination(lastWord);
                        });
                    });
                } else {
                    runOnGui(() => {
                        onCombination("");
                    });
                }


                //GetLastWord();
                
                //runOnGui(() => {
                //    //Console.WriteLine("Do the thing!");
                //    //inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);
                //    //SendKeys.SendWait("Hello");
                //    //inputSimulator.Keyboard.TextEntry("You are doomed");
                //    //inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LWIN);



                //    //var guiInfo = GetCaretPosition();
                //    //var word = GetLastWord(guiInfo.hwndActive);

                //    //Console.WriteLine(guiInfo.cbSize);

                //    //Point caretPosition = new Point();
                //    //ClientToScreen(guiInfo.hwndCaret, out caretPosition);

                //    //caretPosition.X = caretPosition.X + (int)guiInfo.rcCaret.Left + 25;
                //    //caretPosition.Y = caretPosition.Y + (int)guiInfo.rcCaret.Bottom + 25;
                //    //System.Windows.Input.
                //    //System.Runtime.InteropServices.KeyInterop.
                //    //Console.WriteLine(caretPosition);
                //    //Console.WriteLine("name: " + GetActiveProcess());

                //});
                //SendKeys.Send("You are doomed");
            }



            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private static void sendIt(short virtualKey, bool keyUp) {
            int keyboardSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(KeyboardInput));
            // type
            const int INPUT_MOUSE = 0;
            const int INPUT_KEYBOARD = 1;
            const int INPUT_HARDWARE = 2;

            // DwFlags
            const int KEYEVENTF_KEYUP = 0x2;

            //https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput?redirectedfrom=MSDN
            SendInput(1, 
                new KeyboardInput[] {
                    new KeyboardInput() {
                        type = INPUT_KEYBOARD,
                        wVk = virtualKey,
                        wScan = (short)Scancode.sc_c,
                        dwFlags = keyUp ? KEYEVENTF_KEYUP : 0,
                        dwExtraInfo = GetMessageExtraInfo(),
                    }
                }, 
                keyboardSize);


        }
        //private string 

        #region DllImports 
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        /*- Retrieves information about active window or any specific GUI thread -*/
        [DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
        public static extern bool GetGUIThreadInfo(uint tId, out GUITHREADINFO threadInfo);

        /*- Retrieves Title Information of the specified window -*/
        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);
        /*- Retrieves Handle to the ForeGroundWindow -*/
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        /*- Converts window specific point to screen specific -*/
        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, out Point position);
        /*- Retrieves Id of the thread that created the specified window -*/
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs,
   [MarshalAs(UnmanagedType.LPArray), In] KeyboardInput[] pInputs,
   int cbSize);

        [DllImport("user32.dll")]
        private static extern uint GetMessageExtraInfo();

        //[DllImport("kernel32.dll")]
        //public static extern bool Beep(int frequency, int duration);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Beep(uint dwFreq, uint dwDuration);

        #endregion


    }
}
