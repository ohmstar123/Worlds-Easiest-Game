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
            this.finishtopLabel = new System.Windows.Forms.Label();
            this.finishmiddleLabel = new System.Windows.Forms.Label();
            this.finishbottemLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlackBar1
            // 
            this.BlackBar1.BackColor = System.Drawing.Color.Black;
            this.BlackBar1.Location = new System.Drawing.Point(0, 0);
            this.BlackBar1.Name = "BlackBar1";
            this.BlackBar1.Size = new System.Drawing.Size(712, 52);
            this.BlackBar1.TabIndex = 14;
            this.BlackBar1.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // finishtopLabel
            // 
            this.finishtopLabel.AutoSize = true;
            this.finishtopLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishtopLabel.Location = new System.Drawing.Point(221, 148);
            this.finishtopLabel.Name = "finishtopLabel";
            this.finishtopLabel.Size = new System.Drawing.Size(266, 28);
            this.finishtopLabel.TabIndex = 16;
            this.finishtopLabel.Text = "CONGRATULATIONS ";
            // 
            // finishmiddleLabel
            // 
            this.finishmiddleLabel.AutoSize = true;
            this.finishmiddleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishmiddleLabel.Location = new System.Drawing.Point(229, 184);
            this.finishmiddleLabel.Name = "finishmiddleLabel";
            this.finishmiddleLabel.Size = new System.Drawing.Size(249, 28);
            this.finishmiddleLabel.TabIndex = 17;
            this.finishmiddleLabel.Text = "YOU HAVE BEATEN ";
            // 
            // finishbottemLabel
            // 
            this.finishbottemLabel.AutoSize = true;
            this.finishbottemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishbottemLabel.Location = new System.Drawing.Point(173, 219);
            this.finishbottemLabel.Name = "finishbottemLabel";
            this.finishbottemLabel.Size = new System.Drawing.Size(368, 28);
            this.finishbottemLabel.TabIndex = 18;
            this.finishbottemLabel.Text = "THE WORLD\'S EASIEST GAME";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.LightBlue;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Red;
            this.menuButton.Location = new System.Drawing.Point(298, 333);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(120, 39);
            this.menuButton.TabIndex = 20;
            this.menuButton.Tag = "GameScreen";
            this.menuButton.Text = "MAIN MENU";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.finishbottemLabel);
            this.Controls.Add(this.finishmiddleLabel);
            this.Controls.Add(this.finishtopLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlackBar1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScoreScreen";
            this.Size = new System.Drawing.Size(712, 499);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label finishtopLabel;
        private System.Windows.Forms.Label finishmiddleLabel;
        private System.Windows.Forms.Label finishbottemLabel;
        private System.Windows.Forms.Button menuButton;
    }
}
