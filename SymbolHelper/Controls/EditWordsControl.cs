using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolHelper.Storage;
using SymbolHelper.Helpers;

namespace SymbolHelper.Controls {
    public partial class EditWordsControl: UserControl {
        private List<EditWordRowControl> wordControls = new List<EditWordRowControl>();
        private List<Word> words = new List<Word>();

        public EditWordsControl() {
            InitializeComponent();

        }

        private void runOnGui(Action isRunOnGui) {
            if (InvokeRequired) {
                Invoke(isRunOnGui);
            } else {
                isRunOnGui();
            }

        }

        private void WordsControl_Load(object sender, EventArgs e) {
            var wordsStorage = WordStorage.getInstance();

            loadWords(wordsStorage.getWords());
            wordsStorage.wordsUpdated += (words) => {
                runOnGui(() => {
                    loadWords(words);
                });
            };

            wordsStorage.wordUpdated += (word) => {
                runOnGui(() => {
                    EditWordRowControl item = wordControls.Find(control => control.Id == word.Id);
                    if(item != null) {
                        item.Names = word.Names;
                        item.Code = word.Code;
                    } else {
                        var newItem = createWordControl(word);
                        FLPlist.ScrollControlIntoView(newItem);
                    }
                });
            };

            wordsStorage.wordDeleted += removeWord;
        }

        private void removeWord(Word word) {
            foreach (var control in wordControls) {
                if(control.Id == word.Id) {
                    // Remove the control
                    FLPlist.Controls.Remove(control);
                    // stop the search, to prevent iterating a modified list
                    return;
                }
            }
        }


        public EditWordRowControl createWordControl(Word word) {
            var wordItem = new EditWordRowControl();
            wordItem.Id = word.Id;
            wordItem.Names = word.Names;
            wordItem.Code = word.Code;
            FLPlist.Controls.Add(wordItem);
            wordControls.Add(wordItem);
            return wordItem;
        }

        private void loadWords(List<Word> words) {
            FLPlist.Controls.Clear();
            foreach (var word in words) {
                createWordControl(word);
            }
        }

        private void BaddWord_Click(object sender, EventArgs e) {
            WordStorage.getInstance().AddWord(new Word() {
                Id = WordStorage.getInstance().getNextId(),
                Code = "3F",
                Names = "",
            });
        }

        private void Bhide_Click(object sender, EventArgs e) {
            ParentForm.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                WindowsDlls.ReleaseCapture();
                // drag the panel
                WindowsDlls.SendMessage(ParentForm.Handle, WindowsDlls.WM_NCLBUTTONDOWN, WindowsDlls.HT_CAPTION, 0);
            }
        }
    }
}
