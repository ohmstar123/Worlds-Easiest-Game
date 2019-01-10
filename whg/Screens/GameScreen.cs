﻿using System;
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
        SolidBrush gamestartBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush gamemiddleBrush = new SolidBrush(Color.MistyRose);
        SolidBrush gamefinishBrush = new SolidBrush(Color.LimeGreen);
        SolidBrush boundaryBrush = new SolidBrush(Color.LightBlue);
        SolidBrush testBrush = new SolidBrush(Color.Purple);
        SolidBrush extraBrush = new SolidBrush(Color.Yellow);

        List<int> monXList = new List<int>();
        List<int> monYList = new List<int>();
        List<int> monSizeList = new List<int>();
        List<int> monSpeedList = new List<int>();
        List<int> monHPList = new List<int>();

        public GameScreen()
        {
            InitializeComponent();
            InitializeGameValues();
        }

        public void InitializeGameValues()
        {
            //TODO - setup all your initial game values here. Use this method
            // each time you restart your game to reset all values.
            heroX = 100;
            heroY = 100;
            heroSize = 20;
            heroSpeed = 5;
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


            //TODO collisions checks 


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

            //invisible rectangles on outside(remember to turn them into lists later)
            e.Graphics.FillRectangle(boundaryBrush, 0, 0, 712, 100); //1
            e.Graphics.FillRectangle(boundaryBrush, 0, 380, 712, 67); //6
            e.Graphics.FillRectangle(boundaryBrush, 0, 100, 50, 280); //4
            e.Graphics.FillRectangle(boundaryBrush, 620, 100, 92, 280); //5
            e.Graphics.FillRectangle(boundaryBrush, 150, 100, 60, 250); //2
            e.Graphics.FillRectangle(boundaryBrush, 460, 130, 60, 250); //3

            //draw rectangle to screen
            e.Graphics.FillRectangle(heroBrush, heroX, heroY, heroSize, heroSize);
            
        }
    }

}
