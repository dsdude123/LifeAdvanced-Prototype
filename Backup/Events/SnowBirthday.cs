using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class SnowBirthday : Event
    {
        public SnowBirthday()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Birthday Snow";
            this.eventText = "You book a venue for your big 40th Birthday bash, the weather forecast looks good until the day before it starts snowing!";
            this.choice1Text = "Don't worry about it";
            this.choice2Text = "Cancel vendors and move the party to your house";
            this.phaseCodes = new int[1] {4};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "All your vendors cancel and you get stuck with nothing!";
                this.effectText = "-5 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "It makes for a beautiful day and all your friends have a blast.";
                this.effectText = "-4 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "A spontaneous snowball fight breaks out and someone accidentally breaks the window of a neighboring house.";
                this.effectText = "-400 Money";
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
                this.resultText = "Your vendors don’t have good cancellation policies and you must pay for everything!";
                this.effectText = "-1000 Money";
            }
            else if (c == 2)
            {
                this.resultText = "Nobody comes to your party because they didn’t get the location change memo.";
                this.effectText = "-6 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "Everybody shows up and it is way more fun than it would have been, you have a snowball fight in the backyard and it’s the perfect birthday.";
                this.effectText = "+5 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
