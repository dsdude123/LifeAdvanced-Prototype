using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class Earthquake2 : CardEvent
    {
        public Earthquake2()
        {
            this.cardCode = "SHAKE";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Earthquake";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "Your heroics in helping people through the intense earthquake earn you an award from the city, they offer to pay for your school.";
                this.effectText = "+7 Happiness";
            }
            else if (phase == 3)
            {
                this.resultText = "Your child bumps their head at school seeking cover under a desk and is inconsolable, they cry for 6 hours straight.";
                this.effectText = "+6 Stress";
            }
            else if (phase == 4)
            {
                this.resultText = "The old building that your office is in doesn’t hold up well, you are struck with a brick that falls from above the door in which you are bracing yourself, you sustain a concussion.";
                this.effectText = "-5 Physical Wellbeing";
            }
            else if (phase == 5)
            {
                this.resultText = "The family home you grew up in and raised your own kids in has major damages to one side of the house.";
                this.effectText = "-6 Happiness";
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
