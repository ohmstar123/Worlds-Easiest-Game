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

namespace whg
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        //TODO create your global game variables here
        int heroX, heroY, heroSize, heroSpeed;
        SolidBrush heroBrush = new SolidBrush(Color.Red);
        SolidBrush monBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush gamestartBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush gamemiddleBrush = new SolidBrush(Color.MistyRose);
        SolidBrush gamefinishBrush = new SolidBrush(Color.LimeGreen);
        SolidBrush boundaryBrush = new SolidBrush(Color.LightBlue);

        List<int> monXList = new List<int>();
        List<int> monYList = new List<int>();
        List<int> monSizeList = new List<int>();
        List<int> monSpeedList = new List<int>();
        List<int> monLorRList = new List<int>();

        List<int> boundaryXList = new List<int>();
        List<int> boundaryYList = new List<int>();
        List<int> boundaryWList = new List<int>();
        List<int> boundaryHList = new List<int>();

        public GameScreen()
        {
            InitializeComponent();
            InitializeGameValues();
        }

        public void InitializeGameValues()
        {
            //TODO - setup all your initial game values here. Use this method
            // each time you restart your game to reset all values.
            heroX = 90;
            heroY = 240;
            heroSize = 20;
            heroSpeed = 4;
          
            boundaryXList.Add(0);
            boundaryYList.Add(0);
            boundaryWList.Add(712);
            boundaryHList.Add(100);

            boundaryXList.Add(0);
            boundaryYList.Add(380);
            boundaryWList.Add(712);
            boundaryHList.Add(67);

            boundaryXList.Add(0);
            boundaryYList.Add(100);
            boundaryWList.Add(50);
            boundaryHList.Add(280);

            boundaryXList.Add(620);
            boundaryYList.Add(100);
            boundaryWList.Add(92);
            boundaryHList.Add(280);

            boundaryXList.Add(150);
            boundaryYList.Add(100);
            boundaryWList.Add(60);
            boundaryHList.Add(250);

            boundaryXList.Add(460);
            boundaryYList.Add(130);
            boundaryWList.Add(60);
            boundaryHList.Add(250);

            monXList.Add(435);//
            monYList.Add(345);
            monSizeList.Add(25);
            monSpeedList.Add(4);
            monLorRList.Add(1);

            monXList.Add(210);
            monYList.Add(305);
            monSizeList.Add(25);
            monSpeedList.Add(4);
            monLorRList.Add(0);

            monXList.Add(435);//
            monYList.Add(265);
            monSizeList.Add(25);
            monSpeedList.Add(4);
            monLorRList.Add(1);

            monXList.Add(210);
            monYList.Add(225);
            monSizeList.Add(25);
            monSpeedList.Add(4);
            monLorRList.Add(0);

            monXList.Add(435);//
            monYList.Add(185);
            monSizeList.Add(25);
            monSpeedList.Add(4);
            monLorRList.Add(1);

            monXList.Add(210);
            monYList.Add(145);
            monSizeList.Add(25);
            monSpeedList.Add(4);
            monLorRList.Add(0);

            monXList.Add(435);//
            monYList.Add(105);
            monSizeList.Add(25);
            monSpeedList.Add(4);
            monLorRList.Add(1);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // opens a pause screen is escape is pressed. Depending on what is pressed
            // on pause screen the program will either continue or exit to main menu
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    MainForm.ChangeScreen(this, "MenuScreen");
                }
            }

            //TODO - basic player 1 key down bools set below. Add remainging key down
            // required for player 1 or player 2 here.

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //TODO - basic player 1 key up bools set below. Add remainging key up
            // required for player 1 or player 2 here.

            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        /// <summary>
        /// This is the Game Engine and repeats on each interval of the timer. For example
        /// if the interval is set to 16 then it will run each 16ms or approx. 50 times
        /// per second
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int temptX = heroX;
            int temptY = heroY;

            //TODO move main character 
            if (leftArrowDown == true)
            {
                heroX = heroX - heroSpeed;
            }
            if (downArrowDown == true)
            {
                heroY = heroY + heroSpeed;
            }
            if (rightArrowDown == true)
            {
                heroX = heroX + heroSpeed;
            }
            if (upArrowDown == true)
            {
                heroY = heroY - heroSpeed;
            }

            //TODO move npc characters

            for (int i = 0; i < monXList.Count; i++)
            {
                if (monLorRList[i] == 0)
                {
                    monXList[i] = monXList[i] + monSpeedList[i];
                }
                else if (monLorRList[i] == 1)
                {
                    monXList[i] = monXList[i] - monSpeedList[i];
                }
            }

            for (int i = 0; i < monXList.Count; i++)
            {
                if (monXList[i] == 435 & monLorRList[i] == 0)
                {
                    monLorRList[i] = 1;
                    monXList[i] = monXList[i] + monSpeedList[i];
                }
                else if (monXList[i] == 210 & monLorRList[i] == 1)
                {
                    monLorRList[i] = 0;
                    monXList[i] = monXList[i] - monSpeedList[i];
                }
            }

            //TODO collisions checks 
            Rectangle heroRec = new Rectangle(heroX, heroY, heroSize, heroSize);

            for (int i = 0; i < boundaryXList.Count; i++)
            {
                Rectangle BoundaryRec = new Rectangle(boundaryXList[i], boundaryYList[i], boundaryWList[i], boundaryHList[i]);

                if (heroRec.IntersectsWith(BoundaryRec))
                {
                    heroX = temptX;
                    heroY = temptY;
                }
            }


            Rectangle FinishRec = new Rectangle(520, 100, 100, 280);

            if (heroRec.IntersectsWith(FinishRec))
            {
                gameTimer.Enabled = false;
                MainForm.ChangeScreen(this, "ScoreScreen");
            }


            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }


        //Everything that is to be drawn on the screen should be done here
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //game outlay
            e.Graphics.FillRectangle(gamestartBrush, 50, 100, 100, 280);
            e.Graphics.FillRectangle(gamemiddleBrush, 150, 350, 60, 30);
            e.Graphics.FillRectangle(gamemiddleBrush, 210, 100, 250, 280);
            e.Graphics.FillRectangle(gamemiddleBrush, 460, 100, 60, 30);
            e.Graphics.FillRectangle(gamefinishBrush, 520, 100, 100, 280);

            for (int i = 0; i < boundaryHList.Count; i++)
            {
                e.Graphics.FillRectangle(boundaryBrush, boundaryXList[i], boundaryYList[i], boundaryWList[i], boundaryHList[i]);
            }

            //draw rectangle to screen
            e.Graphics.FillRectangle(heroBrush, heroX, heroY, heroSize, heroSize);
            
            for (int i = 0; i < monXList.Count; i++)
            {
                e.Graphics.FillEllipse(monBrush, monXList[i], monYList[i], monSizeList[i], monSizeList[i]);
            }

        }
    }

}
