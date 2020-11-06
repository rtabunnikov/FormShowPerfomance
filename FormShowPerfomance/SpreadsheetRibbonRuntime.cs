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
    public partial class SpreadsheetRibbonRuntime : Form {
        public SpreadsheetRibbonRuntime() {
            InitializeComponent();
            var ribbon = spreadsheetControl1.CreateRibbon();
            ribbon.Parent = this;
            ribbon.Dock = DockStyle.Top;
            var sb = spreadsheetControl1.CreateRibbonStatusBar(ribbon);
            sb.Parent = this;
            sb.Dock = DockStyle.Bottom;
            spreadsheetControl1.Dock = DockStyle.Fill;
        }

        private void SpreadsheetRibbonRuntime_Shown(object sender, EventArgs e) {
            Close();
        }
    }
}
