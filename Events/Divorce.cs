using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class Divorce : Event
    {
        public Divorce()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Divorce";
            this.eventText = "You have recently gone through a divorce. Your friends decided to take you out to the bar for a drink. You happen to sit down next to a person, and the bartender told you that they have gone through a divorce.";
            this.choice1Text = "Very gently and kindly offer them a drink to start a conversation";
            this.choice2Text = "Slide a bottle of beer over towards their direction, wanting a conversation";
            this.phaseCodes = new int[2] {4,5};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You both talk about your lives and interests, everything goes well, and you get their number.";
                this.effectText = "+2 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "They don’t like to be approached so gently and declines your drink.";
                this.effectText = "-2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "They quickly turns away and said they are already seeing someone.";
                this.effectText = "-2 Happiness";
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
                this.resultText = "You show them your different ways to open a bottle, and they were very impressed.";
                this.effectText = "+1 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "They were very shocked by your boldness and instantly fell in love.";
                this.effectText = "+5 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "Introduce yourself and leave, leaving them in a trail of thoughts.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
