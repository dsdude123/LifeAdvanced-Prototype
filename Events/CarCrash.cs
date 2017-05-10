using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class CarCrash : Event
    {
        public CarCrash()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Car Accident";
            this.eventText = "You are involved in a car accident. Fortinutely, no one was hurt. You can stay at the scene and exchange insurance information or you can choose to flee and live life as a hit and run criminal.";
            this.choice1Text = "Stay at Scene";
            this.choice2Text = "Flee";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 3);
            if (c == 1)
            {
                this.resultText = "You exchange insurance information.";
                this.effectText = "-200 Money";
            }
            else if (c == 2)
            {
                this.resultText = "A police officer on scene finds that you were at fault for the accident and tickets you for it.";
                this.effectText = "-500 Money";
            }
            else if (c == 3)
            {
                this.resultText = "The damage to the vehicles ends up being so minimal that the other driver declines to exchange insurance information and lets you go on your way.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
        public override void choice2()
        {
            int c = effectChooser.Next(1, 3);
            if (c == 1)
            {
                this.resultText = "Your attempt to flee seems sucessful at first, but the next morning you are awoken by police at your front door and arrested for hit and run.";
                this.effectText = "Skip 2 turns. -1000 Money";
            }
            else if (c == 2)
            {
                this.resultText = "Your attempt to flee is quickly stopped by the other driver. You are injured in the event.";
                this.effectText = "-3 Health";
            }
            else if (c == 3)
            {
                this.resultText = "You sucessfuly escape the scene of the accident.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }


        

    }
}
