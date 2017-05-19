using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class BusFare : Event
    {
        public BusFare()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Bus Fare";
            this.eventText = "You come from a very poor family, your parents worked very hard to make money and pay for your education. Your parents can only give you 5 dollars for food everyday. One day, a man comes up and says that he’s really rich but he just didn’t carry his wallet on him that day and needs 5 dollars to get home. Would you starve one day and give him the money? Or you think he’s a liar and rather save the money for food instead?";
            this.choice1Text = "Give him the money";
            this.choice2Text = "Save the money";
            this.phaseCodes = new int[1] { 2};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You give the man the money and he thanks you.";
                this.effectText = "-5 Money +1 Happiness -1 Physical Wellbeing";
            }
            else if (c == 2)
            {
                this.resultText = "You give the man the money. A few days later you come across the man again and he recognizes you and repays you greatly for your kind action.";
                this.effectText = "+200 Money -1 Physical Wellbeing";
            }
            else if (c == 3)
            {
                this.resultText = "You give the man the money and later discover that he is a known panhandler and that he lied to you for the money.";
                this.effectText = "-5 Money -1 Physical Wellbeing -1 Happiness";
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
                this.resultText = "You priorize yourself first and save the money.";
                this.effectText = "+1 Physical Wellbeing";
            }
            else if (c == 2)
            {
                this.resultText = "The man turns out to actually be a robber and steals your wallet as you attempt to walk away.";
                this.effectText = "-5 Money -1 Physical Wellbeing";
            }
            else if (c == 3)
            {
                this.resultText = "You save the money and later see the man panhandling on a street corner and feel bad for him.";
                this.effectText = "-1 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
