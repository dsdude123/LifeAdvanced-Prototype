using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class Paris : CardEvent
    {
        public Paris()
        {
            this.cardCode = "BONJOUR";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Vacation to Paris";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "You get food poisoning and have to pay for medical treatment.";
                this.effectText = "-600 Money";
            }
            else if (phase == 3)
            {
                this.resultText = "Your partner proposes to you on the top of the Eiffel Tower.";
                this.effectText = "+8 Happiness";
            }
            else if (phase == 4)
            {
                this.resultText = "Wandering through your favorite museum, you come across the owner who loves your creativity and enthusiasm for the art, he hires you on the spot to become the main curator.";
                this.effectText = "+6 Happiness";
            }
            else if (phase == 5)
            {
                this.resultText = "You stumble upon an amazing deal on a beautiful studio apartment in downtown Paris, you decide to retire here.";
                this.effectText = "-4 Stress";
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
