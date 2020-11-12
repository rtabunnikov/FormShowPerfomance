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
    public partial class RichEditRibbonRuntime : Form {
        public RichEditRibbonRuntime() {
            InitializeComponent();
            var ribbon = richEditControl1.CreateRibbon();
            ribbon.Parent = this;
            ribbon.Dock = DockStyle.Top;
            richEditControl1.Dock = DockStyle.Fill;
        }

        private void RichEditRibbonRuntime_Shown(object sender, EventArgs e) {
            Invalidate(true);
            Update();
            Close();
        }
    }
}
