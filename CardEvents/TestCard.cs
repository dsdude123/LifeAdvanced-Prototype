using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class TestCard : CardEvent
    {
        public TestCard()
        {
            this.cardCode = "TEST123";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Test Card";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "Phase 2";
                this.effectText = "2";
            }
            else if (phase == 3)
            {
                this.resultText = "Phase 3";
                this.effectText = "3";
            }
            else if (phase == 4)
            {
                this.resultText = "Phase 4";
                this.effectText = "4";
            }
            else if (phase == 5)
            {
                this.resultText = "Phase 5";
                this.effectText = "5";
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
