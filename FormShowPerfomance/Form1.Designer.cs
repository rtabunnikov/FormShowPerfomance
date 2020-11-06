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
            this.butRibbonRuntime = new System.Windows.Forms.Button();
            this.butRibbonDesigntime = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(776, 365);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butRibbonDesigntime);
            this.Controls.Add(this.butRibbonRuntime);
            this.Controls.Add(this.butNoRibbon);
            this.Name = "Form1";
            this.Text = "FormShow performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNoRibbon;
        private System.Windows.Forms.Button butRibbonRuntime;
        private System.Windows.Forms.Button butRibbonDesigntime;
        private System.Windows.Forms.TextBox textBox1;
    }
}

