using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolHelper.Helpers;

namespace SymbolHelper.Controls {
    public partial class AboutControl: UserControl  {
        public AboutControl() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.flaticon.com");
        }

        private void Bhide_Click(object sender, EventArgs e) {
            ParentForm.Hide();
        }


        private void button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.flaticon.com");
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                    WindowsDlls.ReleaseCapture();
                    // drag the panel
                    WindowsDlls.SendMessage(ParentForm.Handle, WindowsDlls.WM_NCLBUTTONDOWN, WindowsDlls.HT_CAPTION, 0);
            }            
        }
    }
}
