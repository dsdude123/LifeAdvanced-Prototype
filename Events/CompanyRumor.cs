using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class CompanyRumor : Event
    {
        public CompanyRumor()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Company Rumors";
            this.eventText = "You hear a rumor about big change in the company you hold stocks in.";
            this.choice1Text = "Sell the stocks";
            this.choice2Text = "Keep the stocks";
            this.phaseCodes = new int[3] {3,4,5};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You sell the stocks but no change ends up occuring.";
                this.effectText = "+200 Money";
            }
            else if (c == 2)
            {
                this.resultText = "After selling your stocks, the company releases new products and the price of the stocks goes up.";
                this.effectText = "-300 Money"; //TODO:Might not make sense unless you try to rebuy stocks
            }
            else if (c == 3)
            {
                this.resultText = "The rumor you heard ends up being true and you manage to sell your stocks just in time before the prices crash.";
                this.effectText = "+3 Happiness";
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
                this.resultText = "Fraud is exposed in the company, driving the value of the stocks down.";
                this.effectText = "-500 Money";
            }
            else if (c == 2)
            {
                this.resultText = "The company announces it has aquired another company to support R&D.";
                this.effectText = "+200 Money +1 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "Many other stockholders sell their stock fearing the rumor.  The value of your stocks decrease as a result.";
                this.effectText = "+1 Stress -100 Money";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
