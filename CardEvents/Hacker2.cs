using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class Hacker2 : CardEvent
    {
        public Hacker2()
        {
            this.cardCode = "HACKED";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Nationwide Internet Hacker";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "You are unable to use your iPhone until the computer scientists working for the city can counter and block the hacker.";
                this.effectText = "+7 Stress";
            }
            else if (phase == 3)
            {
                this.resultText = "You work for an internet company and you cannot work until the issue is fixed.";
                this.effectText = "+4 Happiness";
            }
            else if (phase == 4)
            {
                this.resultText = "Your kids are unable to use their phones and are actually interacting with each other.";
                this.effectText = "+6 Happiness";
            }
            else if (phase == 5)
            {
                this.resultText = "Your identity is stolen and the hacker begins making tons of purchases.";
                this.effectText = "-2000 Money";
            }
            else if (phase == 6)
            {
                this.resultText = "Phase 6";
                this.effectText = "6";
            }
            else if (phase == 7)
            {
                this.resultText = "Phase 7";
                this.effectText = "7";
            }
            else if (phase == 8)
            {
                this.resultText = "Phase 8";
                this.effectText = "8";
            }
            else if (phase == 9)
            {
                this.resultText = "Phase 9";
                this.effectText = "9";
            }
        }
    }
}
