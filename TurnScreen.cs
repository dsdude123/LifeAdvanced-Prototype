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
                        if(randomEvent.phaseCodes.Contains<int>(currentPhase))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }
                        else if (randomEvent.phaseCodes.Contains<int>(0))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }

                    }
                }
            }
            else if (Global.playerTurn == 2)
            {
                if (Global.cardTiles.Contains(Global.p2.tilePos))
                {
                    //open card draw screen
                }
                else
                {
                    bool found = false;
                    while (!found)
                    {
                        Event randomEvent = Global.getRandomEvent();
                        int currentPhase = Global.p2.getPhase();
                        if (randomEvent.phaseCodes.Contains(currentPhase))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }
                        else if (randomEvent.phaseCodes.Contains(0))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }

                    }
                }
            }
            else if (Global.playerTurn == 3)
            {
                if (Global.cardTiles.Contains(Global.p3.tilePos))
                {
                    //open card draw screen
                }
                else
                {
                    bool found = false;
                    while (!found)
                    {
                        Event randomEvent = Global.getRandomEvent();
                        int currentPhase = Global.p3.getPhase();
                        if (randomEvent.phaseCodes.Contains(currentPhase))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }
                        else if (randomEvent.phaseCodes.Contains(0))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }

                    }
                }
            }
            else if (Global.playerTurn == 4)
            {
                if (Global.cardTiles.Contains(Global.p4.tilePos))
                {
                    //open card draw screen
                }
                else
                {
                    bool found = false;
                    while (!found)
                    {
                        Event randomEvent = Global.getRandomEvent();
                        int currentPhase = Global.p4.getPhase();
                        if (randomEvent.phaseCodes.Contains(currentPhase))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }
                        else if (randomEvent.phaseCodes.Contains(0))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }

                    }
                }
            }
            else if (Global.playerTurn == 5)
            {
                if (Global.cardTiles.Contains(Global.p5.tilePos))
                {
                    //open card draw screen
                }
                else
                {
                    bool found = false;
                    while (!found)
                    {
                        Event randomEvent = Global.getRandomEvent();
                        int currentPhase = Global.p5.getPhase();
                        if (randomEvent.phaseCodes.Contains(currentPhase))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }
                        else if (randomEvent.phaseCodes.Contains(0))
                        {
                            found = true;
                            Global.currentEvent = randomEvent;
                        }

                    }
                }
            }
            else
            {
                throw new ExecutionEngineException();
            }

            Form newGame = new EventScreen();
            newGame.Show();
            this.Hide();
        }
    }
}
