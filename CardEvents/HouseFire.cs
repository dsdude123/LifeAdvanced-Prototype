using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class HouseFire : CardEvent
    {
        public HouseFire()
        {
            this.cardCode = "HFIRE1";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "House Fire";
            int phase = Global.getCurrentPhase();

            //TODO: Fix the logic order
            if (phase == 2)
            {
                this.resultText = "You lose your laptop which contains all of your test scores, resume, college information, letters of recommendation and college application information.";
                this.effectText = "+7 Stress";
            }
            else if (phase == 3)
            {
                this.resultText = "A family member was unable to get out in time and died in the fire. ";
                this.effectText = "-8 Happiness";
            }
            else if (phase == 4)
            {
                this.resultText = "Your house insurance wasn’t what you thought it was and only half your belongings monetary values can be replaced.";
                this.effectText = "+8 Stress";
            }
            else if (phase == 5)
            {
                this.resultText = "You suffered severe burns to your back and legs saving your family members. ";
                this.effectText = "-8 Physical Wellbeing";
            }
            else if (phase == 6)
            {
                this.resultText = "Phase 5";
                this.effectText = "5";
            }
            else if (phase == 7)
            {
                this.resultText = "Phase 6";
                this.effectText = "6";
            }
            else if (phase == 8)
            {
                this.resultText = "Phase 7";
                this.effectText = "7";
            }
            else if (phase == 9)
            {
                this.resultText = "Phase 8";
                this.effectText = "8";
            }
            else if (phase == 1)
            {
                this.resultText = "Phase 9";
                this.effectText = "9";
            }
        }
    }
}
