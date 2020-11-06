namespace FormShowPerfomance {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.butNoRibbon = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butRibbonRuntime = new System.Windows.Forms.Button();
            this.butRibbonDesigntime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butNoRibbon
            // 
            this.butNoRibbon.Location = new System.Drawing.Point(12, 12);
            this.butNoRibbon.Name = "butNoRibbon";
            this.butNoRibbon.Size = new System.Drawing.Size(184, 45);
            this.butNoRibbon.TabIndex = 0;
            this.butNoRibbon.Text = "No ribbon";
            this.butNoRibbon.UseVisualStyleBackColor = true;
            this.butNoRibbon.Click += new System.EventHandler(this.butNoRibbon_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 356);
            this.listBox1.TabIndex = 1;
            // 
            // butRibbonRuntime
            // 
            this.butRibbonRuntime.Location = new System.Drawing.Point(202, 12);
            this.butRibbonRuntime.Name = "butRibbonRuntime";
            this.butRibbonRuntime.Size = new System.Drawing.Size(184, 45);
            this.butRibbonRuntime.TabIndex = 2;
            this.butRibbonRuntime.Text = "Ribbon runtime";
            this.butRibbonRuntime.UseVisualStyleBackColor = true;
            this.butRibbonRuntime.Click += new System.EventHandler(this.butRibbonRuntime_Click);
            // 
            // butRibbonDesigntime
            // 
            this.butRibbonDesigntime.Location = new System.Drawing.Point(392, 12);
            this.butRibbonDesigntime.Name = "butRibbonDesigntime";
            this.butRibbonDesigntime.Size = new System.Drawing.Size(184, 45);
            this.butRibbonDesigntime.TabIndex = 3;
            this.butRibbonDesigntime.Text = "Ribbon designtime";
            this.butRibbonDesigntime.UseVisualStyleBackColor = true;
            this.butRibbonDesigntime.Click += new System.EventHandler(this.butRibbonDesigntime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butRibbonDesigntime);
            this.Controls.Add(this.butRibbonRuntime);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butNoRibbon);
            this.Name = "Form1";
            this.Text = "FormShow performance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butNoRibbon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butRibbonRuntime;
        private System.Windows.Forms.Button butRibbonDesigntime;
    }
}

