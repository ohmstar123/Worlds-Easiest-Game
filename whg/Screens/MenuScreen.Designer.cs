namespace whg
{
    partial class MenuScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.BlackBar1 = new System.Windows.Forms.Label();
            this.BlackBar2 = new System.Windows.Forms.Label();
            this.MadebyLabel = new System.Windows.Forms.Label();
            this.toptitleLabel = new System.Windows.Forms.Label();
            this.middletitleLabel = new System.Windows.Forms.Label();
            this.bottemtitleLabel = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.loadingtextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightBlue;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(461, 310);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "END GAME";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LightBlue;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Red;
            this.playButton.Location = new System.Drawing.Point(129, 310);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 39);
            this.playButton.TabIndex = 1;
            this.playButton.Tag = "GameScreen";
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // BlackBar1
            // 
            this.BlackBar1.BackColor = System.Drawing.Color.Black;
            this.BlackBar1.Location = new System.Drawing.Point(0, 0);
            this.BlackBar1.Name = "BlackBar1";
            this.BlackBar1.Size = new System.Drawing.Size(714, 52);
            this.BlackBar1.TabIndex = 12;
            this.BlackBar1.Text = "label1";
            // 
            // BlackBar2
            // 
            this.BlackBar2.BackColor = System.Drawing.Color.Black;
            this.BlackBar2.Location = new System.Drawing.Point(0, 447);
            this.BlackBar2.Name = "BlackBar2";
            this.BlackBar2.Size = new System.Drawing.Size(714, 52);
            this.BlackBar2.TabIndex = 13;
            this.BlackBar2.Text = "label1";
            // 
            // MadebyLabel
            // 
            this.MadebyLabel.AutoSize = true;
            this.MadebyLabel.BackColor = System.Drawing.Color.Black;
            this.MadebyLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadebyLabel.ForeColor = System.Drawing.Color.White;
            this.MadebyLabel.Location = new System.Drawing.Point(3, 11);
            this.MadebyLabel.Name = "MadebyLabel";
            this.MadebyLabel.Size = new System.Drawing.Size(263, 30);
            this.MadebyLabel.TabIndex = 14;
            this.MadebyLabel.Text = "Made by: Ohm Patel";
            // 
            // toptitleLabel
            // 
            this.toptitleLabel.AutoSize = true;
            this.toptitleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toptitleLabel.Location = new System.Drawing.Point(152, 148);
            this.toptitleLabel.Name = "toptitleLabel";
            this.toptitleLabel.Size = new System.Drawing.Size(158, 24);
            this.toptitleLabel.TabIndex = 15;
            this.toptitleLabel.Text = "THE WORLD\'S";
            // 
            // middletitleLabel
            // 
            this.middletitleLabel.AutoSize = true;
            this.middletitleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middletitleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.middletitleLabel.Location = new System.Drawing.Point(203, 169);
            this.middletitleLabel.Name = "middletitleLabel";
            this.middletitleLabel.Size = new System.Drawing.Size(315, 45);
            this.middletitleLabel.TabIndex = 16;
            this.middletitleLabel.Text = "EASIEST GAME";
            // 
            // bottemtitleLabel
            // 
            this.bottemtitleLabel.AutoSize = true;
            this.bottemtitleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottemtitleLabel.Location = new System.Drawing.Point(468, 214);
            this.bottemtitleLabel.Name = "bottemtitleLabel";
            this.bottemtitleLabel.Size = new System.Drawing.Size(42, 18);
            this.bottemtitleLabel.TabIndex = 17;
            this.bottemtitleLabel.Text = "v1.0";
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.BackColor = System.Drawing.Color.Black;
            this.failLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failLabel.ForeColor = System.Drawing.Color.White;
            this.failLabel.Location = new System.Drawing.Point(595, 11);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(119, 30);
            this.failLabel.TabIndex = 18;
            this.failLabel.Text = "FAILS: 0";
            this.failLabel.Visible = false;
            // 
            // loadingtextLabel
            // 
            this.loadingtextLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingtextLabel.ForeColor = System.Drawing.Color.Black;
            this.loadingtextLabel.Location = new System.Drawing.Point(156, 192);
            this.loadingtextLabel.Name = "loadingtextLabel";
            this.loadingtextLabel.Size = new System.Drawing.Size(405, 135);
            this.loadingtextLabel.TabIndex = 19;
            this.loadingtextLabel.Text = "THIS WILL BE THE EASIEST TASK OF YOUR LIFE";
            this.loadingtextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadingtextLabel.Visible = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.loadingtextLabel);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.bottemtitleLabel);
            this.Controls.Add(this.middletitleLabel);
            this.Controls.Add(this.toptitleLabel);
            this.Controls.Add(this.MadebyLabel);
            this.Controls.Add(this.BlackBar2);
            this.Controls.Add(this.BlackBar1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(714, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label BlackBar1;
        private System.Windows.Forms.Label BlackBar2;
        private System.Windows.Forms.Label MadebyLabel;
        private System.Windows.Forms.Label toptitleLabel;
        private System.Windows.Forms.Label middletitleLabel;
        private System.Windows.Forms.Label bottemtitleLabel;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Label loadingtextLabel;
    }
}
