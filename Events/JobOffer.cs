using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class JobOffer : Event
    {
        public JobOffer()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Job Offer";
            this.eventText = "Your excellent performance in your position has been recognized by many companies and recruiters. You receive an offer with a higher salary.";
            this.choice1Text = "Tell your manager";
            this.choice2Text = "Leave without explanation";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Your manager grants you a promotion.";
                this.effectText = "+2 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You are relieved of duty from your old job.";
                this.effectText = "No effect";
            }
            else if (c == 3)
            {
                this.resultText = "Your manager raises your salary to the same level as the job offer.";
                this.effectText = "+100 Money";
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
                this.resultText = "You struggle in the new work environment.";
                this.effectText = "+1 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You are quickly promoted at your new company because of your work experience.";
                this.effectText = "+200 Money";
            }
            else if (c == 3)
            {
                this.resultText = "Your new company cuts employess due to a decreasing workload.";
                this.effectText = "-3 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
