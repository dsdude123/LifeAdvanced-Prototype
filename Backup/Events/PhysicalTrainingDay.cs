using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class PhysicalTrainingDay : Event
    {
        public PhysicalTrainingDay()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "International Physical Training Day";
            this.eventText = "Today is the International Physical Training Day! You decide to go to the gym to work out.";
            this.choice1Text = "Get a private instructor";
            this.choice2Text = "Train by yourself";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You recieve professional training from the instructor.";
                this.effectText = "+3 Physical Wellbeing";
            }
            else if (c == 2)
            {
                this.resultText = "The instructor suggest you purchase a training pack.";
                this.effectText = "-200 Money +3 Physical Wellbeing";
            }
            else if (c == 3)
            {
                this.resultText = "The instructor gets carried away in coversation and ends up not training you as well.";
                this.effectText = "+2 Stress"; //This doesn't make sense
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
                this.resultText = "Your training ends up running longer than expected.";
                this.effectText = "-3 Physical Wellbeing";
            }
            else if (c == 2)
            {
                this.resultText = "You choose to do your favorite exercises and enjoy the excercise.";
                this.effectText = "+2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You end up not getting enough excercise."; 
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
