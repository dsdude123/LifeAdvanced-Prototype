using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class StudyAbroad : Event
    {
        public StudyAbroad()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Study Abroad";
            this.eventText = "Your academic record gives you the opportunity to apply to study abroad and complete your degree.";
            this.choice1Text = "Do it";
            this.choice2Text = "Refuse the opportunity";
            this.phaseCodes = new int[3] { 2, 3, 4};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You pay the tuition for the classes. Bon voyage!";
                this.effectText = "-100 Money";
            }
            else if (c == 2)
            {
                this.resultText = "You gain advanced knowledge from your studies overseas.";
                this.effectText = "+2 Knowledge";
            }
            else if (c == 3)
            {
                this.resultText = "The tuition costs turn out to be much higher than expected.";
                this.effectText = "-2 Happiness";
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
                this.resultText = "You find the the competitive environment you enjoyed starts to become less competitive.";
                this.effectText = "-3 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You save money by not studing abroad.";
                this.effectText = "+50 Money";
            }
            else if (c == 3)
            {
                this.resultText = "You decline to study abroad.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
