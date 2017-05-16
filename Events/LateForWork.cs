using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class LateForWork : Event
    {
        public LateForWork()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Late for Work";
            this.eventText = "You get up late today for work.";
            this.choice1Text = "Rush to work";
            this.choice2Text = "Take your time";
            this.phaseCodes = new int[6] { 2, 3, 4, 5, 6, 7 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You arrive at work just in time.";
                this.effectText = "+1 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "In the rush to get to work, you forget to have breakfast.";
                this.effectText = "-3 Energy";
            }
            else if (c == 3)
            {
                this.resultText = "Despite being late, the day goes on to be like a usual day";
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
                this.resultText = "You are caught being late by your boss.";
                this.effectText = "+3 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You are docked pay for being late.";
                this.effectText = "-100 Money";
            }
            else if (c == 3)
            {
                this.resultText = "You arrive at work without anyone noticing your tardiness.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
