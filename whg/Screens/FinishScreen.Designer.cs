namespace whg
{
    partial class ScoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BlackBar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BlackBar1
            // 
            this.BlackBar1.BackColor = System.Drawing.Color.Black;
            this.BlackBar1.Location = new System.Drawing.Point(0, 0);
            this.BlackBar1.Name = "BlackBar1";
            this.BlackBar1.Size = new System.Drawing.Size(714, 52);
            this.BlackBar1.TabIndex = 14;
            this.BlackBar1.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlackBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreScreen";
            this.Size = new System.Drawing.Size(712, 499);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BlackBar1;
        private System.Windows.Forms.Label label1;
    }
}
