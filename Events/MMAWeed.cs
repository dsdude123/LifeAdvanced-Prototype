using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class MMAWeed : Event
    {
        public MMAWeed()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Bad Influences";
            this.eventText = "You're training to become a MMA fighter. All your friends smoke marijuana heavily everyday. You feel it will be ruining your career to remain friends with them. Do you remain friends and potentially abandon your MMA dreams or do you part ways and persure your dream.";
            this.choice1Text = "Stay with friends";
            this.choice2Text = "Part ways";
            this.phaseCodes = new int[1] { 2};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You decide to stay friends and later give in to peer pressure and begin smokin marijuana.";
                this.effectText = "+3 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You decide to stay friends but later develop a severe addiction to marijuana.";
                this.effectText = "+3 Happiness -2 Physical Wellbeing";
            }
            else if (c == 3)
            {
                this.resultText = "You abandon your dreams and remain friends.";
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
                this.resultText = "You part ways with your friends and succesfully become an MMA fighter.";
                this.effectText = "Increase income level by 1. -1 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "You part ways with your friends but unfortinutely never achieve your MMA goals.";
                this.effectText = "-3 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You part ways with your friends.";
                this.effectText = "-2 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
