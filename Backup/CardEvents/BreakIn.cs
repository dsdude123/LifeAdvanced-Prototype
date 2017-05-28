using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class BreakIn : CardEvent
    {
        public BreakIn()
        {
            this.cardCode = "ROBBED";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Break-In";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "Your car was stolen and you have a big interview tomorrow.";
                this.effectText = "+5 Stress";
            }
            else if (phase == 3)
            {
                this.resultText = "Your brand new living room set from Pottery Barn was taken.";
                this.effectText = "-4 Happiness";
            }
            else if (phase == 4)
            {
                this.resultText = "The cash you were storing for your kids college fund was snatched.";
                this.effectText = "+8 Stress";
            }
            else if (phase == 5)
            {
                this.resultText = "Your late mother's expensive jewelry box was stolen.";
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
