using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class IdentityTheft : Event
    {
        public IdentityTheft()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Identity Theft";
            this.eventText = "Someone steals your identity and gets your tax return sent to them and cashes it. You find out that it was your brother. It was only a few thousand dollars but you could get him sent to prison.";
            this.choice1Text = "Contact the IRS";
            this.choice2Text = "Let it slide";
            this.phaseCodes = new int[5] {2,3,4,5,6};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Your brother is arrested for identitity theft. Unfortinutely, the funds have already been spent."; //Spell check
                this.effectText = "-2 Happiness -3 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "In the investigation leadin up to you brothers arrest, it is discovered that he was part of a larger crime ring. You are given an reward for the discovery of this information.";
                this.effectText = "-2 Happiness +500 Money";
            }
            else if (c == 3)
            {
                this.resultText = "No evidence linking your brother to the crime is discovered.";
                this.effectText = "No effect";
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
                this.resultText = "Your brother gets away with the crime.";
                this.effectText = "No effect";
            }
            else if (c == 2)
            {
                this.resultText = "It is later discovered that your brother also opened credit cards with your stolen identity.";
                this.effectText = "+3 Stress -200 Money";
            }
            else if (c == 3)
            {
                this.resultText = "Your brother later attempts the crime with different person and is caught.";
                this.effectText = "-2 Happiness -1 Stress";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
