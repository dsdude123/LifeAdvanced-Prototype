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
             if (checkEndGame())
            {
                Form newGame = new GameOver();
                newGame.Show();
                newGame.Location = this.Location;
                this.Hide();
                Global.playerTurn = -1;
                
            }
            
            if (Global.playerTurn == 1)
            {
                if (Global.p1.tilePos >= Global.endPos)
                {
                    ResultScreen skip = new ResultScreen();
                    skip.turnOverride();
                }
                label1.Text = "Player 1's Turn";
            }
            else if (Global.playerTurn == 2)
            {
                if (Global.p2.tilePos >= Global.endPos)
                {
                    ResultScreen skip = new ResultScreen();
                    skip.turnOverride();
                }
                label1.Text = "Player 2's Turn";
            }
            else if (Global.playerTurn == 3)
            {
                if (Global.p3.tilePos >= Global.endPos)
                {
                    ResultScreen skip = new ResultScreen();
                    skip.turnOverride();
                }
                label1.Text = "Player 3's Turn";
            }
            else if (Global.playerTurn == 4)
            {
                if (Global.p4.tilePos >= Global.endPos)
                {
                    ResultScreen skip = new ResultScreen();
                    skip.turnOverride();
                }
                label1.Text = "Player 4's Turn";
            }
            else if (Global.playerTurn == 5)
            {
                if (Global.p5.tilePos >= Global.endPos)
                {
                    ResultScreen skip = new ResultScreen();
                    skip.turnOverride();
                }
                label1.Text = "Player 5's Turn";
            }
            if (Global.playerTurn != -1)
            {
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (Global.playerTurn == 1)
            {
                if (Global.cardTiles.Contains(Global.p1.tilePos))
                {
                    Form newGamea = new CardScreen();
                    newGamea.Show();
                    newGamea.Location = this.Location;
                    this.Hide();
                    return;
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
                    Form newGameb = new CardScreen();
                    newGameb.Show();
                    newGameb.Location = this.Location;
                    this.Hide();
                    return;
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
                    Form newGamec = new CardScreen();
                    newGamec.Show();
                    newGamec.Location = this.Location;
                    this.Hide();
                    return;
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
                    Form newGamed = new CardScreen();
                    newGamed.Show();
                    newGamed.Location = this.Location;
                    this.Hide();
                    return;
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
                    Form newGamee = new CardScreen();
                    newGamee.Show();
                    newGamee.Location = this.Location;
                    this.Hide();
                    return;
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
                throw new ArgumentOutOfRangeException();
            }

            Form newGame = new EventScreen();
            newGame.Show();
            newGame.Location = this.Location;
            this.Hide();
        }

        public bool checkEndGame()
        {
            if (Global.numPlayers == 1)
            {
                if (Global.p1.tilePos >= Global.endPos)
                {
                    return true;
                }
            }
            else if (Global.numPlayers == 2)
            {
                if ((Global.p1.tilePos >= Global.endPos) && (Global.p2.tilePos >= Global.endPos))
                {
                    return true;
                }
            }
            else if (Global.numPlayers == 3)
            {
                if ((Global.p1.tilePos >= Global.endPos) && (Global.p2.tilePos >= Global.endPos) && (Global.p3.tilePos >= Global.endPos))
                {
                    return true;
                }
            }
            else if (Global.numPlayers == 4)
            {
                if ((Global.p1.tilePos >= Global.endPos) && (Global.p2.tilePos >= Global.endPos) && (Global.p3.tilePos >= Global.endPos) && (Global.p4.tilePos >= Global.endPos))
                {
                    return true;
                }
            }
            else if (Global.numPlayers == 5)
            {
                if ((Global.p1.tilePos >= Global.endPos) && (Global.p2.tilePos >= Global.endPos) && (Global.p3.tilePos >= Global.endPos) && (Global.p4.tilePos >= Global.endPos) && (Global.p5.tilePos >= Global.endPos))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
