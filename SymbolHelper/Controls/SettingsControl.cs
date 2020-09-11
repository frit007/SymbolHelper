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
using SymbolHelper.Storage;

namespace SymbolHelper {
    public partial class SettingsControl: UserControl {
        public SettingsControl() {
            InitializeComponent();

            loadSettings();
            SettingsStorage.getInstance().settingsUpdated += (_) => {
                loadSettings();
            };
        }

        public void loadSettings() {
            var settings = SettingsStorage.getInstance().getSettings();
            CBautoClose.Checked = settings.AutoHide;
            CBselectTextOnOpen.Checked = settings.SelectWordInOriginalProgram;
            CBconfirmDelete.Checked = settings.ConfirmDelete;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Bhide_Click(object sender, EventArgs e) {
            ParentForm.Hide();
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                WindowsDlls.ReleaseCapture();
                // drag the panel
                WindowsDlls.SendMessage(ParentForm.Handle, WindowsDlls.WM_NCLBUTTONDOWN, WindowsDlls.HT_CAPTION, 0);
            }
        }

        private void CBselectTextOnOpen_CheckedChanged(object sender, EventArgs e) {
            var settings = SettingsStorage.getInstance().getSettings();
            if (settings.SelectWordInOriginalProgram != CBselectTextOnOpen.Checked) {
                settings.SelectWordInOriginalProgram = CBselectTextOnOpen.Checked;
                SettingsStorage.getInstance().update(settings);
            }
        }

        private void CBautoClose_CheckedChanged(object sender, EventArgs e) {
            var settings = SettingsStorage.getInstance().getSettings();
            if(settings.AutoHide != CBautoClose.Checked) {
                settings.AutoHide = CBautoClose.Checked;
                SettingsStorage.getInstance().update(settings);
            }
        }

        private void CBconfirmDelete_CheckedChanged(object sender, EventArgs e) {
            var settings = SettingsStorage.getInstance().getSettings();
            if (settings.ConfirmDelete != CBconfirmDelete.Checked) {
                settings.ConfirmDelete = CBconfirmDelete.Checked;
                SettingsStorage.getInstance().update(settings);
            }
        }
    }
}
