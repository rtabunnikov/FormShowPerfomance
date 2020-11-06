using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormShowPerfomance {
    public partial class SpreadsheetNoRibbon : Form {
        public SpreadsheetNoRibbon() {
            InitializeComponent();
        }

        private void SpreadsheetNoRibbon_Shown(object sender, EventArgs e) {
            Invalidate(true);
            Update();
            Close();
        }
    }
}
