using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class GamblingAddiction : Event
    {
         public GamblingAddiction()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Gambling Addiction";
            this.eventText = "You take it ill-advised trip to Las Vegas with your friends from work. You end up losing the house in a poker game. What do you tell your kids? That's some of your stock investments ran dry and you will have to move into an apartment or do you reveal that you're a compulsive Gambler and need to go to Gamblers Anonymous.";
            this.choice1Text = "Tell the truth";
            this.choice2Text = "Lie";
            this.phaseCodes = new int[1] {6};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Your move into an appartment and register for Gamblers Anonymous.";
                this.effectText = "-200 Money";
            }
            else if (c == 2)
            {
                this.resultText = "Despite coming out with the truth, your gambling addiction continues costing you family money and your family members trust.";
                this.effectText = "-2 Happiness -500 Money";
            }
            else if (c == 3)
            {
                this.resultText = "You sucessfully complete Gamblers Anonymous.";
                this.effectText = "+1 Happiness -1 Stress";
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
                this.resultText = "Your family later discovers your gambling addiction costing you their trust.";
                this.effectText = "-2 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You eventually get over your gambling addiction by your own self determination.";
                this.effectText = "+3 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "Your addiction continues to grow eventually destorying your families finances.";
                this.effectText = "Bankrupt. Set your money to 0.";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
