using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class Layoff : Event
    {
        public Layoff()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Layoffs";
            this.eventText = "You lose your job this moring due to the company reducing its workforce.";
            this.choice1Text = "Take a month break";
            this.choice2Text = "Seek a new job imediately"; //Spell check me
            this.phaseCodes = new int[1] {3};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You take a months break and find a new job when more comapnies are hiring.";
                this.effectText = "No effect.";
            }
            else if (c == 2)
            {
                this.resultText = "Without an income, bills begin to drain your account.";
                this.effectText = "-400 Money";
            }
            else if (c == 3)
            {
                this.resultText = "You take a nice trip during your month break.";
                this.effectText = "-2 Stress";
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
                this.resultText = "You apply to many jobs but sturggle to move forward in the hiring process.";
                this.effectText = "+1 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "Your sucessfully find a new job.";
                this.effectText = "+2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You take a part-time job to cover your living expenses.";
                this.effectText = "+400 Money"; //Maybe set income level to 1 (100 per turn)
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
