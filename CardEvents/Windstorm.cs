using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class Windstorm : CardEvent 
    {
        public Windstorm()
        {
            this.cardCode = "WIND15";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Windstorm";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "A tree falls on your beloved car.";
                this.effectText = "-800 Money";
            }
            else if (phase == 3)
            {
                this.resultText = "Your daughter's school is shut down for a week and you must stay home from work to watch her.";
                this.effectText = "+6 Stress";
            }
            else if (phase == 4)
            {
                this.resultText = "The power goes out in your house and you and your family must live with no power for 5 days before the city can come out and fix it.";
                this.effectText = "-5 Happiness";
            }
            else if (phase == 5)
            {
                this.resultText = "A tree in your yard falls on your neighbor's house and they sue you for damages and you settle out of court.";
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
