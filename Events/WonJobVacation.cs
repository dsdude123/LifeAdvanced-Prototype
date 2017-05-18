using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class WonJobVacation : Event
    {
        public WonJobVacation()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Vacation";
            this.eventText = "Your excellent performance on a project at work is noticed by your boss and you are granted a one-week vacation.";
            this.choice1Text = "Go traveling";
            this.choice2Text = "Stay at home";
            this.phaseCodes = new int[6] { 2, 3, 4, 5, 6, 7 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You choose to fly to your destination but find that all the flights are sold out.";
                this.effectText = "-2 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You purchase lots of gifts on your trip.";
                this.effectText = "-100 Money +1 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You have a relaxing trip.";
                this.effectText = "-3 Stress";
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
                this.resultText = "You take your time off to handle some personal matters.";
                this.effectText = "-2 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You work extra hours at your part-time job during the week.";
                this.effectText = "+150 Money";
            }
            else if (c == 3)
            {
                this.resultText = "You decide to be lazy and sleep for most of the week.";
                this.effectText = "+2 Physical Wellbeing";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
