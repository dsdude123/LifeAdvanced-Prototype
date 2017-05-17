using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class Match4 : Event
    {

        /*
         *This event might need more balance because of the high effect amounts. That being said, whats the probability of this ocurring? 
         */
         public Match4()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Match 4";
            this.eventText = "You find out you won the Washington Match 4. The prize is 10 thousand dollars. Your girlfriend at the time as being lying and cheating on you. Do you stick with her and try to work things out while you share your lottery winnings or do you move on and try to find somebody new?";
            this.choice1Text = "Try to work things out";
            this.choice2Text = "Leave her";
            this.phaseCodes = new int[1] {5};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "After going through consuling, you both sucessfully work things out and you enjoy your new fortune";
                this.effectText = "+10000 Money +3 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "Despite attempting to work things out, your girlfriend continues to cheat and eventually leaves you taking half of the fortune with her.";
                this.effectText = "+5000 Money -5 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You sucessfully work things out and use the money to pay off old debts.";
                this.effectText = "Remove all stress";
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
                this.resultText = "Your girlfriend discovers your win and sucessfully sues you for a portion of the money. After legal fees, your left with a mere 25% of your original winnings.";
                this.effectText = "+2500 Money +2 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You dump your girlfriend and sucessfully get away with your winnings.";
                this.effectText = "+10000 Money";
            }
            else if (c == 3)
            {
                this.resultText = "After dumping your girlfriend, you discover that you misread the winning numbers and did not actually win.";
                this.effectText = "-5 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
