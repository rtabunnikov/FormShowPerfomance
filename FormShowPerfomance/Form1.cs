using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormShowPerfomance {
    public partial class Form1 : Form {
        const int n = 30;
        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        void Measure(string name, Action action) {
            var times = new double[n];
            for (int i = 0; i < n; i++) {
                sw.Restart();
                action();
                Application.DoEvents();
                sw.Stop();
                times[i] = sw.Elapsed.TotalMilliseconds;
            }
            var result = PrepareResult(name, times);
            PrintResult(result);
        }

        PerfResult PrepareResult(string name, double[] times) {
            Array.Sort(times);
            int n = times.Length;
            var result = new PerfResult() {
                Name = name,
                Min = times[0],
                Max = times[n - 1]
            };
            double total = 0;
            for (int i = 0; i < n; i++)
                total += times[i];
            result.Mean = total / n;
            if (n == 1)
                result.Median = times[0];
            else if (n % 2 == 1)
                result.Median = times[n / 2];
            else
                result.Median = (times[n / 2] + times[n / 2 - 1]) / 2;
            return result;
        }

        void PrintResult(PerfResult result) {
            var sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.AppendLine(result.Name);
            sb.AppendLine($"Min:    {result.Min:F3} ms");
            sb.AppendLine($"Max:    {result.Max:F3} ms");
            sb.AppendLine($"Avg:    {result.Mean:F3} ms");
            sb.AppendLine($"Median: {result.Median:F3} ms");
            textBox1.Text = sb.ToString();
        }

        private void butNoRibbon_Click(object sender, EventArgs e) {
            Measure("XtraSpreadsheet w/o ribbon", RunNoRibbon);
        }

        void RunNoRibbon() {
            using (var frm = new SpreadsheetNoRibbon())
                frm.ShowDialog();
        }

        private void butRibbonRuntime_Click(object sender, EventArgs e) {
            Measure("XtraSpreadsheet ribbon runtime", RunRibbonRuntime);
        }

        void RunRibbonRuntime() {
            using (var frm = new SpreadsheetRibbonRuntime())
                frm.ShowDialog();
        }

        private void butRibbonDesigntime_Click(object sender, EventArgs e) {
            Measure("XtraSpreadsheet ribbon designtime", RunRibbonDesigntime);
        }

        void RunRibbonDesigntime() {
            using (var frm = new SpreadsheetRibbonDesigntime())
                frm.ShowDialog();
        }
    }
}
