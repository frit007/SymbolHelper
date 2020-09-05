using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SymbolHelper.Helpers;
using SymbolHelper.Storage;
using SymbolHelper.Controls;

namespace SymbolHelper {
    public partial class SearchControl: UserControl {

        public class SearchOptimizedWord {
            public String[] Names { get; set; }
            public Word Word { get; set; }
        }

        public class ScoredWord {
            public double Score { get; set; }
            public SearchOptimizedWord Word { get; set; }
        }

        public List<SearchWordRowControl> controls = new List<SearchWordRowControl>();
        int selectedIndex = 0;

        public void updateSelectedIndex(int newIndex) {
            int visibleCount = controls.Count((control) => control.Visible);

            if (visibleCount > 0) { 
                controls[selectedIndex].IsSelected = false;
                if(newIndex >= visibleCount) {
                    newIndex = 0;
                } else if(newIndex < 0) {
                    newIndex = visibleCount - 1;
                }
                controls[newIndex].IsSelected = true;
                selectedIndex = newIndex;
                FLPwords.ScrollControlIntoView(controls[newIndex]);
            }
        }

        public SearchControl() {
            InitializeComponent();
            createWordCache();
            var wordStorage = WordStorage.getInstance();

            wordStorage.wordDeleted += (_) => {
                createWordCache();
            };
            wordStorage.wordsUpdated += (_) => {
                createWordCache();
            };
            wordStorage.wordUpdated += (_) => {
                createWordCache();
            };
            setupList();
        }

        private void setupList() {
            FLPwords.Controls.Clear();
            for (int i = 0; i < 10; i++) {
                var control = new SearchWordRowControl();
                control.Visible = false;
                FLPwords.Controls.Add(control);
                controls.Add(control);
            }
        }
        
        public List<SearchOptimizedWord> searchOptimizedWords = new List<SearchOptimizedWord>();

        void createWordCache() {
            searchOptimizedWords = WordStorage.getInstance().getWords().Select((word) => new SearchOptimizedWord() {
                Word = word,
                Names = word.Names.Split().Select(name => name.Trim()).ToArray()
            }).ToList();
            search();
        }


        private void TBsearch_TextChanged(object sender, EventArgs e) {
            search();
        }

        public void search() {
            var search = TBsearch.Text;
            if (search == "") {
                // if nothing was typed yet then don't show anything, since any result would be random
                foreach (var control in controls) {
                    control.Visible = false;
                }
                return;
            }
            var scoredWords = searchOptimizedWords.Select(
                word => new ScoredWord() {
                    // Score = word.Names.Min(name => Helpers.LevenshteinDistance.Compute(search, name)),
                    // divide by the length of the word, so short words have a smaller advantage.
                    Score = word.Names.Min(name => Helpers.LevenshteinDistance.Compute(name,search) / (double) name.Length),
                    Word = word
                }
            );

            var ordered = scoredWords.OrderBy(word => word.Score);
            var bestResults = ordered.Take(10).ToList();

            for (int i = 0; i < controls.Count; i++) {
                var control = controls[i];
                // make sure we don't go out range
                if (bestResults.Count > i ) {
                    var result = bestResults[i];
                    control.Visible = true;
                    control.Names = string.Join(", ", result.Word.Names);
                    control.Code = result.Word.Word.Code;
                    control.Id = result.Word.Word.Id;
                } else {
                    control.Visible = false;
                }
            }

            updateSelectedIndex(0);
        }

        public void UpdateText(String newText) {
            TBsearch.Text = newText;
            TBsearch.Focus();
            TBsearch.Select(newText.Length, 0);
        }

        
        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                WindowsDlls.ReleaseCapture();
                // drag the panel
                WindowsDlls.SendMessage(ParentForm.Handle, WindowsDlls.WM_NCLBUTTONDOWN, WindowsDlls.HT_CAPTION, 0);
            }
        }

        private void Bhide_Click(object sender, EventArgs e) {
            ParentForm.Hide();
        }

        private void TBsearch_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Down:
                    updateSelectedIndex(selectedIndex + 1);
                    break;
                case Keys.Up:
                    updateSelectedIndex(selectedIndex - 1);
                    break;
                case Keys.Enter:
                    var code = controls[selectedIndex].Code;
                    ParentForm.Hide();
                    KeyHandler.sendString(UTF8Helper.hexStringToLetter(code));
                    break;
                case Keys.Escape:
                    ParentForm.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}