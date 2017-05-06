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
    public partial class GameSetup : Form
    {
        private static int players;

        public GameSetup()
        {
            InitializeComponent();
            players = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            players = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            if (players == 1)
            {
                Global.numPlayers = players;
                Global.p1 = new Player(Global.demoPos);
            }
            else if (players == 2)
            {
                Global.numPlayers = players;
                Global.p1 = new Player(Global.demoPos);
                Global.p2 = new Player(Global.demoPos);
            }
            else if (players == 3)
            {
                Global.numPlayers = players;
                Global.p1 = new Player(Global.demoPos);
                Global.p2 = new Player(Global.demoPos);
                Global.p3 = new Player(Global.demoPos);
            }
            else if (players == 4)
            {
                Global.numPlayers = players;
                Global.p1 = new Player(Global.demoPos);
                Global.p2 = new Player(Global.demoPos);
                Global.p3 = new Player(Global.demoPos);
                Global.p4 = new Player(Global.demoPos);
            }
            else if (players == 5)
            {
                Global.numPlayers = players;
                Global.p1 = new Player(Global.demoPos);
                Global.p2 = new Player(Global.demoPos);
                Global.p3 = new Player(Global.demoPos);
                Global.p4 = new Player(Global.demoPos);
                Global.p5 = new Player(Global.demoPos);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
