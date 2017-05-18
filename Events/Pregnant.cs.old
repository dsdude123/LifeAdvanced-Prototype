using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class Pregnant : Event
    {
        public Pregnant()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Pregnant";
            this.eventText = "After your honney moon, you discover that you are pregnant. You decide to take";
            this.choice1Text = "a natural birth";
            this.choice2Text = "a caesarean";
            this.phaseCodes = new int[3] { 2, 3, 4};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "The birth ends up being very difficult.";
                this.effectText = "-5 Physical wellbeing";
            }
            else if (c == 2)
            {
                this.resultText = "The birth is sucessful.";
                this.effectText = "-3 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "The birth goes as planned.";
                this.effectText = "No effect";
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
                this.resultText = "The hospital bill for the operation ends up being very expensive.";
                this.effectText = "-400 Money";
            }
            else if (c == 2)
            {
                this.resultText = "Your suffer from a long recovery time.";
                this.effectText = "-2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "The birth ends up being less painful.";
                this.effectText = "-3 Stress";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
