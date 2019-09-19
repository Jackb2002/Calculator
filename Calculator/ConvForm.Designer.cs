namespace Calculator
{
    partial class ConvForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.radioDen = new System.Windows.Forms.RadioButton();
            this.radioHex = new System.Windows.Forms.RadioButton();
            this.radioBin = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "mainMenuStrip";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.graphingToolStripMenuItem,
            this.convertionsToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.basicToolStripMenuItem.Text = "Basic";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click);
            // 
            // graphingToolStripMenuItem
            // 
            this.graphingToolStripMenuItem.Name = "graphingToolStripMenuItem";
            this.graphingToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.graphingToolStripMenuItem.Text = "Graphing";
            this.graphingToolStripMenuItem.Click += new System.EventHandler(this.graphingToolStripMenuItem_Click);
            // 
            // convertionsToolStripMenuItem
            // 
            this.convertionsToolStripMenuItem.Checked = true;
            this.convertionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convertionsToolStripMenuItem.Name = "convertionsToolStripMenuItem";
            this.convertionsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.convertionsToolStripMenuItem.Text = "Convertions";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 97);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(243, 20);
            this.inputBox.TabIndex = 30;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // radioDen
            // 
            this.radioDen.AutoSize = true;
            this.radioDen.Checked = true;
            this.radioDen.Location = new System.Drawing.Point(12, 27);
            this.radioDen.Name = "radioDen";
            this.radioDen.Size = new System.Drawing.Size(64, 17);
            this.radioDen.TabIndex = 31;
            this.radioDen.TabStop = true;
            this.radioDen.Text = "Base-10";
            this.radioDen.UseVisualStyleBackColor = true;
            this.radioDen.CheckedChanged += new System.EventHandler(this.radioDen_CheckedChanged);
            // 
            // radioHex
            // 
            this.radioHex.AutoSize = true;
            this.radioHex.Location = new System.Drawing.Point(12, 50);
            this.radioHex.Name = "radioHex";
            this.radioHex.Size = new System.Drawing.Size(44, 17);
            this.radioHex.TabIndex = 32;
            this.radioHex.Text = "Hex";
            this.radioHex.UseVisualStyleBackColor = true;
            this.radioHex.CheckedChanged += new System.EventHandler(this.radioHex_CheckedChanged);
            // 
            // radioBin
            // 
            this.radioBin.AutoSize = true;
            this.radioBin.Location = new System.Drawing.Point(12, 74);
            this.radioBin.Name = "radioBin";
            this.radioBin.Size = new System.Drawing.Size(54, 17);
            this.radioBin.TabIndex = 33;
            this.radioBin.Text = "Binary";
            this.radioBin.UseVisualStyleBackColor = true;
            this.radioBin.CheckedChanged += new System.EventHandler(this.radioBin_CheckedChanged);
            // 
            // ConvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 129);
            this.Controls.Add(this.radioBin);
            this.Controls.Add(this.radioHex);
            this.Controls.Add(this.radioDen);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConvForm";
            this.Text = "Conversion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConvForm_FormClosed);
            this.Load += new System.EventHandler(this.ConvForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertionsToolStripMenuItem;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.RadioButton radioDen;
        private System.Windows.Forms.RadioButton radioHex;
        private System.Windows.Forms.RadioButton radioBin;
    }
}