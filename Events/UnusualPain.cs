using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class UnusualPain : Event
    {
        public UnusualPain()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Unusual Pain";
            this.eventText = "You begin to notice signs of arthritis in your hands while you are working.";
            this.choice1Text = "Ignore it and hope it goes away";
            this.choice2Text = "Go to the doctor and get it checked out";
            this.phaseCodes = new int[1] {5};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "It was nothing, false alarm!";
                this.effectText = "-2 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "The pain continues to grow, you freak out that you are getting old.";
                this.effectText = "-4 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "It is much worse than you thought, expensive treatments."; //TODO:Might need to reword this
                this.effectText = "-300 Money";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
        public override void choice2()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "It isn’t arthritis, false alarm!";
                this.effectText = "-2 Stres";
            }
            else if (c == 2)
            {
                this.resultText = "The doctor prescribes you medical marijuana and totally relieves the pain.";
                this.effectText = "+4 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "It is a potentially cancerous tumor.";
                this.effectText = "-7 Physical Wellbeing";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
