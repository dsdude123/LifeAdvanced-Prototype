using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeAdvanced
{
    public partial class TurnScreen : Form
    {
        public TurnScreen()
        {
            InitializeComponent();
        }

        private void TurnScreen_Load(object sender, EventArgs e)
        {
            if (Global.playerTurn == 1)
            {
                label1.Text = "Player 1's Turn";
            }
            else if (Global.playerTurn == 2)
            {
                label1.Text = "Player 2's Turn";
            }
            else if (Global.playerTurn == 3)
            {
                label1.Text = "Player 3's Turn";
            }
            else if (Global.playerTurn == 4)
            {
                label1.Text = "Player 4's Turn";
            }
            else if (Global.playerTurn == 5)
            {
                label1.Text = "Player 5's Turn";
            }

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (Global.playerTurn == 1)
            {
                if (Global.cardTiles.Contains(Global.p1.tilePos))
                {
                    //open card draw screen
                }
                else
                {
                    bool found = false;
                    while (!found)
                    {
                        Event randomEvent = Global.getRandomEvent();
                        int currentPhase = Global.p1.getPhase();
                        if(randomEvent.phaseCodes.Contains(currentPhase))
                        {
                            found = true;
                        }
                        else if (randomEvent.phaseCodes.Contains(0))
                        {
                            found = true;
                        }
                    }
                }
            }
            else if (Global.playerTurn == 2)
            {
                label1.Text = "Player 2's Turn";
            }
            else if (Global.playerTurn == 3)
            {
                label1.Text = "Player 3's Turn";
            }
            else if (Global.playerTurn == 4)
            {
                label1.Text = "Player 4's Turn";
            }
            else if (Global.playerTurn == 5)
            {
                label1.Text = "Player 5's Turn";
            }


            /**
             * get current player
             * if (Player.titlePos = CARD_TILES)
             * then open card draw screen
             * else
             * while event not selected
             * get random event
             * check age restriction
             * if valid or no restriction end while
             * 
             * open event screen
             */
            //event code here
        }
    }
}
