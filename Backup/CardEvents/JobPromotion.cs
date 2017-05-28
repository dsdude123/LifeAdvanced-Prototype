using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class JobPromotion : CardEvent
    {
        public JobPromotion()
        {
            this.cardCode = "MOVINGUP";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Job Promotion";
            int phase = Global.getCurrentPhase();
            //TODO: Fix logic order
            if (phase == 2)
            {
                this.resultText = "$2 an hour raise!";
                this.effectText = "+4 Happiness";
            }
            else if (phase == 3)
            {
                this.resultText = "You are now the youngest CEO of the company ever! You are set for life!";
                this.effectText = "-8 Stress";
            }
            else if (phase == 4)
            {
                this.resultText = "Your father has chosen you to replace him over your older brother who also works for the family business, drama erupts when you take the job.";
                this.effectText = "+4 Stress";
            }
            else if (phase == 5)
            {
                this.resultText = "Your promotion doubles the amount of money being put into retirement for you, along with a raise in salary.";
                this.effectText = "-7 Stress";
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
