using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeAdvanced
{
    public partial class AdvancedOptions : Form
    {
        public Form callingForm;
        public AdvancedOptions()
        {
            InitializeComponent();
        }

        public AdvancedOptions(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Global.tileSkip = (int) numericUpDown1.Value;
            }
            else
            {
                Global.tileSkip = 1;
            }
            callingForm.Enabled = true;
            this.Hide();

        }
    }
}
