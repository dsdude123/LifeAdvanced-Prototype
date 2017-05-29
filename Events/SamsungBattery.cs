using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class SamsungBattery : Event
    {
        public SamsungBattery()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "New Phone";
            this.eventText = "You see an ad for a new smartphone on TV. You really want to get it but you are concerned about the cost.";
            this.choice1Text = "Buy it";
            this.choice2Text = "Don't buy it";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Your cell carrier informs you that ypu are elligible for a free upgrade.";
                this.effectText = "+3 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "The phone ends up costing less than you expected.";
                this.effectText = "-200 Money +3 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "The new model ends up having a battery defect and you are injured when it explodes in your pocket.";
                this.effectText = "-3 Physical Wellbeing";
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
                this.resultText = "The money saved ends up helping pay for bills the next month.";
                this.effectText = "-2 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "Your phone breaks a few weeks later forcing you to upgrade.";
                this.effectText = "-400 Money";
            }
            else if (c == 3)
            {
                this.resultText = "It is later discovered that the new model had a battery defect and all the phones had to be recalled.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
