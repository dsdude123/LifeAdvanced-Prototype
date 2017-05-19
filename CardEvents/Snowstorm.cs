using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class Snowstorm : CardEvent
    {
        public Snowstorm()
        {
            this.cardCode = "SNOW167";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Snowstorm";
            int phase = Global.getCurrentPhase();
            //TODO: Fix logic order (why do I keep doing this!?)
            if (phase == 2)
            {
                this.resultText = "School is cancelled for two weeks, woo-hoo! ";
                this.effectText = "+6 Happiness";
            }
            else if (phase == 3)
            {
                this.resultText = "When the snow began you underestimated the warnings and stayed at work for too long, you now must find a way to get home.";
                this.effectText = "+5 Stress";
            }
            else if (phase == 4)
            {
                this.resultText = "Your insane boss insists you find a way into work or you’re fired, you get minor frostbite getting to your car.";
                this.effectText = "-4 Physical Wellbeing";
            }
            else if (phase == 5)
            {
                this.resultText = "Your 4 grandkids are at your home when the snow hits and are unable to leave until the city is clear.";
                this.effectText = "-6 Stress"; //Effect doesn't match the resultText?
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
