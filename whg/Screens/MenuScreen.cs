using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;
using System.Threading;

namespace whg
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            exitButton.Visible = false;
            toptitleLabel.Visible = false;
            middletitleLabel.Visible = false;
            bottemtitleLabel.Visible = false;

            failLabel.Visible = true;
            loadingtextLabel.Visible = true;
            MadebyLabel.Text = "Level: 1";

            Refresh();
            Thread.Sleep(3000);

            MainForm.ChangeScreen(this, "GameScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Enter(object sender, EventArgs e)
        {
            //start by changing all the buttons to the default colour
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    c.BackColor = Color.White;
            }

            //change the current button to the active colour
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
        }

    }
}
