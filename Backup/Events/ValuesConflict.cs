using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class ValuesConflict : Event
    {
        public ValuesConflict()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Conflict of Values";
            this.eventText = "You're being recruited for the Marines and your family who has a history of being in the military want you to go. You recently became a Buddhist and don't believe in violence in any means. What do you do let your family down and not join the Marines or decide to join the military and worry about religious beliefs later.";
            this.choice1Text = "Refuse to join";
            this.choice2Text = "Join the Marines";
            this.phaseCodes = new int[1] { 2};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Your family judges you for your choice but you feel good about your decision.";
                this.effectText = "+2 Happiness +1 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "Your family understands your values and accepts your decision.";
                this.effectText = "+3 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You decline to join the Marines.";
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
                this.resultText = "Despite your values, you join the Marines gaining approval from your family.";
                this.effectText = "-3 Happiness -2 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "During a required physical examination, you are determined to be unfit to join the Marines.";
                this.effectText = "-2 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "You join the Marines but your tour of duty is cut short when you are injured by an IED.";
                this.effectText = "-4 Physical Wellbeing";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
