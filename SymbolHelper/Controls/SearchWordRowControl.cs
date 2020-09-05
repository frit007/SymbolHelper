using SymbolHelper.Helpers;
using System.Drawing;
using System.Windows.Forms;

namespace SymbolHelper.Controls {
    public partial class SearchWordRowControl: UserControl {
        private Color defaultBackColor;
        public SearchWordRowControl() {
            InitializeComponent();
            defaultBackColor = BackColor;
        }

        public string Names {
            set {
                Lnames.Text = value;
            }
        }
        public int Id { get; set; }
        private string code;
        public string Code {
            get {
                return code;
            }
            set {
                Lletter.Text = UTF8Helper.hexStringToLetter(value);
                code = value;
            }
        }

        private bool selected;
        public bool IsSelected {
            get {
                return selected;
            }
            set {
                selected = value;
                if(selected) {
                    BackColor = Color.LightBlue;
                } else {
                    BackColor = defaultBackColor;
                }
            }
        }


    }
}
