using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class NewBusiness : Event
    {
        public NewBusiness()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Business Owner";
            this.eventText = "Dissatified with your work, you consider forming your own business. However, you are unsure whether you will be sucessful. Do you leave your company for this new adventure or do you stick it out at your current job?";
            this.choice1Text = "Form new business";
            this.choice2Text = "Stay";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You form a new business which becomes highly sucessful.";
                this.effectText = "+2 Happiness. Raise your income level by 1.";
            }
            else if (c == 2)
            {
                this.resultText = "Your new business doesn't make as much money as your former job but you love the new business.";
                this.effectText = "+3 Happiness. Lower your income level by 1.";
            }
            else if (c == 3)
            {
                this.resultText = "The business ends up being a complete failure.";
                this.effectText = "-3 Happiness";
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
                this.resultText = "Working conditions at your work improve making you feel better about not leaving.";
                this.effectText = "-2 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You continued to be disatisfied and eventually decided to leave the job.";
                this.effectText = "Lower your income level by 1.";
            }
            else if (c == 3)
            {
                this.resultText = "You decide to stay with your current employer.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
