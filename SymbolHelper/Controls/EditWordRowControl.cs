using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SymbolHelper.Storage;
using SymbolHelper.Helpers;

namespace SymbolHelper.Controls {
    public partial class EditWordRowControl: UserControl {
        public EditWordRowControl() {
            InitializeComponent();
        }

        public int Id { get; set; }

        [Category("Custom Props")]
        public string Names {
            get { return TBname.Text; }
            set {
                if (TBname.Text != value) { 
                    TBname.Text = value; 
                }
            }
        }

        public void updateLetter() {

            string code = TBcode.Text;

            try {
                Lletter.Text = UTF8Helper.hexStringToLetter(code);
            } catch(Exception ex) {
                if (code.Length > 0) {
                    byte[] bytes = Encoding.UTF8.GetBytes(code.Substring(0,1));
                    string hex = BitConverter.ToString(bytes).Replace("-", "");
                    TBcode.Text = hex;
                }
            }
        }

        [Category("Custom Props")]
        public string Code {
            get { return TBcode.Text;  }
            set { TBcode.Text = value; updateLetter(); }
        }

        private void Lcode_Click(object sender, EventArgs e) {

        }

        private void TBcode_TextChanged(object sender, EventArgs e) {
            updateLetter();
            var word = WordStorage.getInstance().getWordById(Id);
            if (word.Code != TBcode.Text) {
                word.Code = TBcode.Text;
                WordStorage.getInstance().UpdateWord(word);
            }
        }

        private void Pdelete_Click(object sender, EventArgs e) {
            if (SettingsStorage.getInstance().getSettings().ConfirmDelete) {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                ParentForm.Show();
                if (confirmResult == DialogResult.Yes) {
                    WordStorage.getInstance().removeWord(Id);
                }

            } else {
                WordStorage.getInstance().removeWord(Id);
            }
        }

        private void TBname_TextChanged(object sender, EventArgs e) {
            var word = WordStorage.getInstance().getWordById(Id);
            if (word.Names != TBname.Text) {
                word.Names = TBname.Text;
                WordStorage.getInstance().UpdateWord(word);
            }

        }
    }
}
