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
    public partial class CardScreen : Form
    {
        public CardScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String code = textBox1.Text;
            bool found = false;
            
            foreach(CardEvent c in Global.cardDatabase)
            {
                if (c.cardCode.Equals(code.ToUpper()))
                {
                    Global.currentCardEvent = c;
                    found = true;
                }

            }
            if (!found)
            {
                MessageBox.Show("The code that has been entered does not match any of the cards.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Global.isCard = true;
                Global.currentCardEvent.initEvent();
                Form newGame = new ResultScreen();
                newGame.Show();
                newGame.Location = this.Location;
                this.Hide();
                
            }

        }

        private void CardScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
