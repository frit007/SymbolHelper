using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolHelper.Storage {
    class Settings {
        public bool SelectWordInOriginalProgram { get; set; } = true;
        public bool AutoHide { get; set; } = true;
        public bool ConfirmDelete { get; set; } = true;
    }
}
