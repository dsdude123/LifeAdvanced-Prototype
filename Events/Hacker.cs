using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class Hacker : Event
    {
        public Hacker()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Hacked";
            this.eventText = "You love to use computers, and uses multiple screens to do homework and play games/watching netflix simultaneously. One day you start noticing some of your files have disappeared, and some of your accounts are inaccessible caused by a hacker implanting a virus on your computer. Would you try to hire a professional to remove the virus and recover the files/accounts, or spend a lot of money/time to buy a new computer and redo those files/accounts?";
            this.choice1Text = "Hire a professional";
            this.choice2Text = "Buy a new computer";
            this.phaseCodes = new int[1] { 2};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You hire a professional and they sucessfully revert the damage done by the hacker.";
                this.effectText = "-200 Money -5 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "The professional is able to fix your computer but unfortinutely is unbale to recover your files and accounts.";
                this.effectText = "-200 Money +5 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "The professional refuses to repair your computer because of its age and recommends buying a new computer.";
                this.effectText = "-500 Money";
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
                this.resultText = "You buy a new computer and abandon your old files and accounts.";
                this.effectText = "-700 Money +5 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "Before buying a computer, you make an attempt to remove the virus yourself and are sucessful, saving yourself from an unnecessary purchase.";
                this.effectText = "+1 Knowledge -5 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "You buy a new computer and later sucessfully recover your old files and accounts.";
                this.effectText = "-700 Money -3 Stress";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
