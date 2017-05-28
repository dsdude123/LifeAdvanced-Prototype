using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class Earthquake : Event
    {
        public Earthquake()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Earthquake";
            this.eventText = "An earthquake occurs while you are at home! You must act quickly!";
            this.choice1Text = "Hide under a table";
            this.choice2Text = "Go outside";
            this.phaseCodes = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "The earthquake quickly passes away.";
                this.effectText = "No effect";
            }
            else if (c == 2)
            {
                this.resultText = "Your house collapses burying you in the debris. Fortinutely, you are quickly rescued by first responders.";
                this.effectText = "+3 Stress -2 Physical Wellbeing";
            }
            else if (c == 3)
            {
                this.resultText = "Sections of the ceiling fall to the floor. Fortinutely, the table saves you from any injury.";
                this.effectText = "+3 Happiness";
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
                this.resultText = "You move to open ground and the earthquake passes away.";
                this.effectText = "No effect";
            }
            else if (c == 2)
            {
                this.resultText = "You escape the house before it collaspes. You are unharmed in the event.";
                this.effectText = "+2 Happiness"; //This seems off...
            }
            else if (c == 3)
            {
                this.resultText = "You are injured by falling debris.";
                this.effectText = "-2 Physical Wellbeing";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
