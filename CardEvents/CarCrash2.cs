using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class CarCrash2 : CardEvent
    {
        public CarCrash2()
        {
            this.cardCode = "WRECKED";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Car Crash";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "You were borrowing a friends car and they are extremely upset with you, you must pay to fix the damages.";
                this.effectText = "-1600 Money";
            }
            else if (phase == 3)
            {
                this.resultText = "You break your leg in the crash.";
                this.effectText = "-6 Physical Wellbeing";
            }
            else if (phase == 4)
            {
                this.resultText = "Your friend suffers whiplash and gets a concussion.";
                this.effectText = "+5 Stress";
            }
            else if (phase == 5)
            {
                this.resultText = "The dream car that you were finally able to purchase is totaled in the wreck, your insurance won’t replace the car.";
                this.effectText = "-8 Happiness";
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
