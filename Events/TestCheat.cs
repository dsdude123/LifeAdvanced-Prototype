using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class TestCheat : Event
    {
        public TestCheat()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Cheating";
            this.eventText = "You forgot to study on a test. Your friend has very good test grades. Do you cheat off his test and risk being caught or understand your own failure to study and take whatever grade you get.";
            this.choice1Text = "Cheat";
            this.choice2Text = "Don't cheat";
            this.phaseCodes = new int[2] { 2, 3};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You sucessfully cheat off the test.";
                this.effectText = "-2 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You are caught cheating on the test and kicked out of class.";
                this.effectText = "+5 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "Your friend ends up not doing well on the test.";
                this.effectText = "-2 Knowledge";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        public override void choice2()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "The test ends up being a lot easier than you expected.";
                this.effectText = "+5 Knowledge";
            }
            else if (c == 2)
            {
                this.resultText = "Your teacher announces that retakes will be allowed on this test giving you another chance to do well.";
                this.effectText = "-3 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "You fail the test.";
                this.effectText = "-3 Knowledge";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
