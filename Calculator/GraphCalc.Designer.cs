namespace Calculator
{
    partial class GraphCalc
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
                LinePen.Dispose();
                pen.Dispose();
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
            this.lineModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalGraphOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.quadraticGraphOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.drawBtn = new System.Windows.Forms.Button();
            this.graphBox = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._CVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.removeCMultOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.lineModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
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
            this.graphingToolStripMenuItem.Checked = true;
            this.graphingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.graphingToolStripMenuItem.Name = "graphingToolStripMenuItem";
            this.graphingToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.graphingToolStripMenuItem.Text = "Graphing";
            // 
            // convertionsToolStripMenuItem
            // 
            this.convertionsToolStripMenuItem.Name = "convertionsToolStripMenuItem";
            this.convertionsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.convertionsToolStripMenuItem.Text = "Convertions";
            this.convertionsToolStripMenuItem.Click += new System.EventHandler(this.convertionsToolStripMenuItem_Click);
            // 
            // lineModeToolStripMenuItem
            // 
            this.lineModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalGraphOpt,
            this.quadraticGraphOpt,
            this.removeCMultOpt});
            this.lineModeToolStripMenuItem.Name = "lineModeToolStripMenuItem";
            this.lineModeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.lineModeToolStripMenuItem.Text = "Line Mode";
            // 
            // normalGraphOpt
            // 
            this.normalGraphOpt.Checked = true;
            this.normalGraphOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalGraphOpt.Name = "normalGraphOpt";
            this.normalGraphOpt.Size = new System.Drawing.Size(180, 22);
            this.normalGraphOpt.Text = "Y=MX+C";
            this.normalGraphOpt.Click += new System.EventHandler(this.YMXCToolStripMenuItem_Click);
            // 
            // quadraticGraphOpt
            // 
            this.quadraticGraphOpt.Name = "quadraticGraphOpt";
            this.quadraticGraphOpt.Size = new System.Drawing.Size(180, 22);
            this.quadraticGraphOpt.Text = "AX^2+BX+C";
            this.quadraticGraphOpt.Click += new System.EventHandler(this.AX2BXCToolStripMenuItem_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(440, 372);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(83, 49);
            this.drawBtn.TabIndex = 36;
            this.drawBtn.Text = "Draw!";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // graphBox
            // 
            this.graphBox.BackColor = System.Drawing.Color.White;
            this.graphBox.Location = new System.Drawing.Point(12, 27);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(511, 339);
            this.graphBox.TabIndex = 37;
            this.graphBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphBox_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 49);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Y=MX+C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.AVal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BVal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this._CVal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 49);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AX^2 + BX + C ";
            this.groupBox2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "²";
            // 
            // AVal
            // 
            this.AVal.Location = new System.Drawing.Point(55, 20);
            this.AVal.Name = "AVal";
            this.AVal.Size = new System.Drawing.Size(42, 20);
            this.AVal.TabIndex = 39;
            this.AVal.TextChanged += new System.EventHandler(this.AVal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "A";
            // 
            // BVal
            // 
            this.BVal.Location = new System.Drawing.Point(213, 20);
            this.BVal.Name = "BVal";
            this.BVal.Size = new System.Drawing.Size(63, 20);
            this.BVal.TabIndex = 37;
            this.BVal.TextChanged += new System.EventHandler(this.BVal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "B";
            // 
            // _CVal
            // 
            this._CVal.Location = new System.Drawing.Point(349, 20);
            this._CVal.Name = "_CVal";
            this._CVal.Size = new System.Drawing.Size(63, 20);
            this._CVal.TabIndex = 35;
            this._CVal.TextChanged += new System.EventHandler(this._CVal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "M";
            // 
            // mValue
            // 
            this.mValue.Location = new System.Drawing.Point(147, 19);
            this.mValue.Name = "mValue";
            this.mValue.Size = new System.Drawing.Size(54, 20);
            this.mValue.TabIndex = 31;
            this.mValue.TextChanged += new System.EventHandler(this.MValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Y=";
            // 
            // cValue
            // 
            this.cValue.Location = new System.Drawing.Point(291, 19);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(63, 20);
            this.cValue.TabIndex = 35;
            this.cValue.TextChanged += new System.EventHandler(this.CValue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "X+C";
            // 
            // removeCMultOpt
            // 
            this.removeCMultOpt.Name = "removeCMultOpt";
            this.removeCMultOpt.Size = new System.Drawing.Size(180, 22);
            this.removeCMultOpt.Text = "Remove C Zoom";
            this.removeCMultOpt.Click += new System.EventHandler(this.RemoveCMultOpt_Click);
            // 
            // GraphCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GraphCalc";
            this.Text = "Graphs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphCalc_FormClosed);
            this.Load += new System.EventHandler(this.GraphCalc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertionsToolStripMenuItem;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Panel graphBox;
        private System.Windows.Forms.ToolStripMenuItem lineModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalGraphOpt;
        private System.Windows.Forms.ToolStripMenuItem quadraticGraphOpt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _CVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem removeCMultOpt;
    }
}