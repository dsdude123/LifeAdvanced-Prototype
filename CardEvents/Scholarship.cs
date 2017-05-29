using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.CardEvents
{
    class Scholarship : CardEvent
    {
        public Scholarship()
        {
            this.cardCode = "SCHOLAR13";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Scholarship";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "You recieve an academic scholarship for your excellent performance in school.";
                this.effectText = "+5000 Money";
            }
            else if (phase == 3)
            {
                this.resultText = "You recieve an academic scholarship for your excellent performance in school helping you to complete your PhD.";
                this.effectText = "+2500 Money +6 Knowledge";
            }
            else if (phase == 4)
            {
                this.resultText = "Your child earns an academic scholarship.";
                this.effectText = "+4 Happiness";
            }
            else if (phase == 5)
            {
                this.resultText = "Your child earns an academic scholarship.";
                this.effectText = "+4 Happiness";
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
