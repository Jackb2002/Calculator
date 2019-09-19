namespace Calculator
{
    partial class SnakeForm
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
            this.components = new System.ComponentModel.Container();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // outputPanel
            // 
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.Location = new System.Drawing.Point(0, 0);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(284, 261);
            this.outputPanel.TabIndex = 0;
            this.outputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.outputPanel_Paint);
            // 
            // drawTimer
            // 
            this.drawTimer.Enabled = true;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outputPanel);
            this.Name = "SnakeForm";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.SnakeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Timer drawTimer;
    }
}