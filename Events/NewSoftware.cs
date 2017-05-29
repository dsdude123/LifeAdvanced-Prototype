using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class NewSoftware : Event
    {
        public NewSoftware()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "New Software";
            this.eventText = "A new version of the software on your computer is released. It is promoted as having greater stability and security. You could upgrade, but you could also save the money.";
            this.choice1Text = "Upgrade";
            this.choice2Text = "Don't upgrade";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "The new software runs great on your computer.";
                this.effectText = "-200 Money +1 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "The new software ends up having more issues than benefits.";
                this.effectText = "-200 Money +1 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "Your computer ends up not being compatible with the new software.";
                this.effectText = "No effect";
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
                this.resultText = "The new software ends up getting terrible reviews.";
                this.effectText = "-1 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "A security hole is descovered in the older versions of the software.";
                this.effectText = "+2 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "You decide not to upgrade.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
