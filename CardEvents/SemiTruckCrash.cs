using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class SemiTruckCrash : CardEvent
    {
        public SemiTruckCrash()
        {
            this.cardCode = "BIGRIG";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Semi-Truck Crash";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "You sit in traffic for 2 hours trying to get to work without actually moving only for your boss to call you off.";
                this.effectText = "-4 Happiness";
            }
            else if (phase == 3)
            {
                this.resultText = "You are stuck at work and cannot pick up your children from daycare.";
                this.effectText = "+4 Stress";
            }
            else if (phase == 4)
            {
                this.resultText = "You were signed up for a nonrefundable yoga retreat that you cannot make it to anymore.";
                this.effectText = "-600 Money";
            }
            else if (phase == 5)
            {
                this.resultText = "You were front and center to the accident and are in a minor crash of your own trying to avoid the semi.";
                this.effectText = "-3 Physical Wellbeing";
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
