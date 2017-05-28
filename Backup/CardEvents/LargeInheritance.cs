using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class LargeInheritance : CardEvent
    {
        public LargeInheritance()
        {
            this.cardCode = "MONEYLG";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Large Inheritance";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "You decide to ball out and buy a Lamborghini";
                this.effectText = "+10 Happiness";
            }
            else if (phase == 3)
            {
                this.resultText = "You choose to use the money to go back to school to earn your PhD";
                this.effectText = "+8 Knowledge";
            }
            else if (phase == 4)
            {
                this.resultText = "You buy your mom the home she’s always wanted.";
                this.effectText = "+7 Happiness";
            }
            else if (phase == 5)
            {
                this.resultText = "You invest in stocks and your money grows by 600%.";
                this.effectText = "-7 Stress";
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
