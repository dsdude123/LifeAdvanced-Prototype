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
    public partial class EventScreen : Form
    {
        public EventScreen()
        {
            InitializeComponent();
        }

        private void EventScreen_Load(object sender, EventArgs e)
        {
            title.Text = Global.currentEvent.eventName;
            text.Text = Global.currentEvent.eventText;
            choice1.Text = Global.currentEvent.choice1Text;
            choice2.Text = Global.currentEvent.choice2Text;
        }

        private void choice1_Click(object sender, EventArgs e)
        {
            Global.currentEvent.choice1();
            //go to results
        }

        private void choice2_Click(object sender, EventArgs e)
        {
            Global.currentEvent.choice2();
            //go to results
        }
    }
}
