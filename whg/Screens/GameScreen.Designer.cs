namespace whg
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.BlackBar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.MadebyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // BlackBar1
            // 
            this.BlackBar1.BackColor = System.Drawing.Color.Black;
            this.BlackBar1.Location = new System.Drawing.Point(0, 0);
            this.BlackBar1.Name = "BlackBar1";
            this.BlackBar1.Size = new System.Drawing.Size(714, 52);
            this.BlackBar1.TabIndex = 13;
            this.BlackBar1.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.BackColor = System.Drawing.Color.Black;
            this.failLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failLabel.ForeColor = System.Drawing.Color.White;
            this.failLabel.Location = new System.Drawing.Point(579, 11);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(119, 30);
            this.failLabel.TabIndex = 19;
            this.failLabel.Text = "FAILS: 0";
            // 
            // MadebyLabel
            // 
            this.MadebyLabel.AutoSize = true;
            this.MadebyLabel.BackColor = System.Drawing.Color.Black;
            this.MadebyLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadebyLabel.ForeColor = System.Drawing.Color.White;
            this.MadebyLabel.Location = new System.Drawing.Point(3, 11);
            this.MadebyLabel.Name = "MadebyLabel";
            this.MadebyLabel.Size = new System.Drawing.Size(110, 30);
            this.MadebyLabel.TabIndex = 20;
            this.MadebyLabel.Text = "Level: 1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.MadebyLabel);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlackBar1);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(712, 499);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label BlackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Label MadebyLabel;
    }
}
