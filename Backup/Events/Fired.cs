using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class Fired : Event
    {
        public Fired()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Pending Termination";
            this.eventText = "You constanly miss meetings and fail to finish work on time. Your boss finally got tired of you and decided that he wants to fire you.";
            this.choice1Text = "Discuss the problem with the boss";
            this.choice2Text = "Get mad";
            this.phaseCodes = new int[6] { 2, 3, 4, 5, 6, 7};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You beg the boss for another chance. Fortinutely, he grants you one.";
                this.effectText = "-1 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You do a favor for the boss to earn another chance.";
                this.effectText = "No effect";
            }
            else if (c == 3)
            {
                this.resultText = "Despite your attempts, the boss still fires you.";
                this.effectText = "Reduce your income level by 1.";
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
                this.resultText = "You quickly pack up and leave.";
                this.effectText = "+1 Stress. Reduce your income level by 1.";
            }
            else if (c == 2)
            {
                this.resultText = "In an rage of anger you hit your boss who then calls the cops. You are arrested.";
                this.effectText = "Skip 1 turn. -100 Money. Reduce your income level by 1.";
            }
            else if (c == 3)
            {
                this.resultText = "You decide to trash talk to boss to try to get others to leave the company with you.";
                this.effectText = "-3 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
