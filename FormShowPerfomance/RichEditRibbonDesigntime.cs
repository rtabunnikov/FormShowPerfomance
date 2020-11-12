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
    public partial class RichEditRibbonDesigntime : Form {
        public RichEditRibbonDesigntime() {
            InitializeComponent();
        }

        private void RichEditRibbonDesigntime_Shown(object sender, EventArgs e) {
            Invalidate(true);
            Update();
            Close();
        }
    }
}
