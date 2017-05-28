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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {


        }

        private void GameOver_Shown(object sender, EventArgs e)
        {
            List<Form> activeForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                activeForms.Add(f);
            }
            foreach (Form f in activeForms)
            {
                if (f.Name == "TurnScreen") //This is kinda a hack but it works
                {
                    f.Close();
                }
            }
        }

    }
}
