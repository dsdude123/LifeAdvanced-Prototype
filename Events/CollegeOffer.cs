using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class CollegeOffer : Event
    {
        public CollegeOffer()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "College Offer";
            this.eventText = "You receive the offers from your dream college outside of the state as well as the best college in your state.";
            this.choice1Text = "Attend the Dream College";
            this.choice2Text = "Attend the Best Local College";
            this.phaseCodes = new int[1] { 2};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You dsicover that the college had a competitive environment.";
                this.effectText = "+1 Stress +2 Knowledge";
            }
            else if (c == 2)
            {
                this.resultText = "The rent costs for housing near you college are very high.";
                this.effectText = "-300 Money";
            }
            else if (c == 3)
            {
                this.resultText = "You attend your dream college.";
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
                this.resultText = "You run into some old friends at your college.";
                this.effectText = "+1 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "Attending a local college allows you to live at home with your parents.";
                this.effectText = "+200 Money";
            }
            else if (c == 3)
            {
                this.resultText = "The college has a less competitve degree program.";
                this.effectText = "+3 Stress";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
