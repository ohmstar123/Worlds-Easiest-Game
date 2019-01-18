using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace whg
{
    public partial class ScoreScreen : UserControl
    {
        System.Windows.Media.MediaPlayer gamesoundPlayer;

        public ScoreScreen()
        {
            InitializeComponent();

            gamesoundPlayer = new System.Windows.Media.MediaPlayer();
            gamesoundPlayer.Open(new Uri(Application.StartupPath + "/Resources/Fireworks.mp3"));
            gamesoundPlayer.Play();
        }

        private void ScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //when the escape key is pressed the game ends and goes back to the main menu
            if (e.KeyCode == Keys.Escape)
            {
                MainForm.ChangeScreen(this, "MenuScreen");
            }
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            gamesoundPlayer.Stop();
            MainForm.ChangeScreen(this, "MenuScreen");
        }
    }
}
