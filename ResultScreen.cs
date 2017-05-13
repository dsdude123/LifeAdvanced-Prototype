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
    public partial class ResultScreen : Form
    {
        public ResultScreen()
        {
            InitializeComponent();
        }

        private void EventScreen_Load(object sender, EventArgs e)
        {
            title.Text = Global.currentEvent.eventName;
            text.Text = Global.currentEvent.resultText;

        }

        private void choice1_Click(object sender, EventArgs e)
        {
            if (Global.playerTurn < Global.numPlayers)
            {
                advancePosition();
                Global.playerTurn++;
            }
            else
            {
                advancePosition();
                Global.playerTurn = 1;
            }
            Form newGame = new TurnScreen();
            newGame.Show();
            newGame.Location = this.Location;
            this.Hide();


        }

        public void turnOverride()
        {
            choice1_Click(new Object(),new EventArgs());

        }

        private void advancePosition()
        {
            if (Global.playerTurn == 1)
            {
                Global.p1.tilePos++;
            }
            else if (Global.playerTurn == 2)
            {
                Global.p2.tilePos++;
            }
            else if (Global.playerTurn == 3)
            {
                Global.p3.tilePos++;
            }
            else if (Global.playerTurn == 4)
            {
                Global.p4.tilePos++;
            }
            else if (Global.playerTurn == 5)
            {
                Global.p5.tilePos++;
            }

        }
    }
}
