using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class GFCheat : Event
    {
        public GFCheat()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Cheating";
            this.eventText = "You arrive at your girlfriend's house and enter without knocking and discover her hooking up with your best friend. What do you do find a new girlfriend and a new best friend or kick one of them to the curb and remain cool with the other one.";
            this.choice1Text = "End relations with both";
            this.choice2Text = "End relations with one";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You end relations with both of your friends.";
                this.effectText = "-5 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You end relations with both of your friends.";
                this.effectText = "-5 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You end relations with both of your friends.";
                this.effectText = "-5 Happiness";
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
                this.resultText = "You end relations with your best friend and stay with your girlfriend who later cheats on you again.";
                this.effectText = "-5 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You end relations with your best friend and stay with your girlfriend.";
                this.effectText = "-2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You end relations with your girlfriend and stay with your best friend.";
                this.effectText = "-2 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
