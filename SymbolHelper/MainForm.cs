using SymbolHelper.Helpers;
using SymbolHelper.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymbolHelper {
    public partial class MainForm: Form {

        // map userControls to a button so panel kan go to the correct position
        Dictionary<UserControl, Button> userControlButton = new Dictionary<UserControl, Button>();

        // if keepOpenLocks 0 then don't autohide the window
        int keepOpenLocks = 0;

        public MainForm() {
            InitializeComponent();

            KeyHandler.Start((selectedWord, caretPosition) => {
                WindowState = FormWindowState.Minimized;
                Show();
                WindowState = FormWindowState.Normal;
                //caretPosition.X += -400;
                //caretPosition.Y += -100;
                Location = caretPosition;
                showUserControl(SCsearch);
                SCsearch.UpdateText(selectedWord);
            }, runOnGui);

            Storage.Storage.getInstance().Setup();

        }

        private void runOnGui(Action isRunOnGui) {
            if(InvokeRequired) {
                Invoke(isRunOnGui);
            } else {
                isRunOnGui();
            }

        }

        private void Form1_Shown(object sender, EventArgs e) {
            userControlButton.Add(SCsettings, Bsettings);
            userControlButton.Add(SCsearch, Bsearch);
            userControlButton.Add(SCwords, BWords);
            userControlButton.Add(SCabout, Babout);

            Hide();
        }

        private void showUserControl(UserControl userControl) {
            foreach (var pair in userControlButton) {
                if (pair.Key == userControl) {
                    pair.Key.Visible = true;
                    PactiveWindow.Visible = pair.Value != null;
                    if (pair.Value != null) {
                        PactiveWindow.Top = pair.Value.Top;
                    }
                } else {
                    pair.Key.Visible = false;
                }
            }

        }

        //private void textBox1_MouseEnter(object sender, EventArgs e) {
        //    //SendKeys.SendWait("Hello");
        //    KeyHandler.inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);
        //    SendKeys.SendWait("+^{LEFT}");
        //    //inputSimulator.Keyboard.ModifiedKeyStroke(new List<WindowsInput.Native.VirtualKeyCode>() {
        //    //    WindowsInput.Native.VirtualKeyCode.CONTROL,
        //    //}, WindowsInput.Native.VirtualKeyCode.VK_C);
        //    // copy
        //    SendKeys.SendWait("^{C}");
            
        //}


        private void Bexit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void searchControl1_Load(object sender, EventArgs e) {

        }

        private void Bsearch_Click(object sender, EventArgs e) {
            showUserControl(SCsearch);
        }

        private void Bsettings_Click(object sender, EventArgs e) {
            showUserControl(SCsettings);
        }


        //// https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();
        //private void Ptop_MouseDown(object sender, MouseEventArgs e) {

        //    if (e.Button == MouseButtons.Left) {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}

        private void Form1_Leave(object sender, EventArgs e) {
            Hide();
        }

        private void Form1_Deactivate(object sender, EventArgs e) {
            if(SettingsStorage.getInstance().getSettings().AutoHide) {
                Hide();
            }
        }

        private void BWords_Click(object sender, EventArgs e) {
            showUserControl(SCwords);
        }

        private void Bhide_Click(object sender, EventArgs e) {
            Hide();
        }

        private void label1_Click(object sender, EventArgs e) {
            
        }

        private void Babout_Click(object sender, EventArgs e) {
            showUserControl(SCabout);
        }

        private void BIcon_Click(object sender, EventArgs e) {
            showUserControl(SCabout);
        }
    }
}
