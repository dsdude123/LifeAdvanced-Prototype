using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class DogPadlock : Event
    {
        public DogPadlock()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Pet Surgery";
            this.eventText = "Your dog swallows padlock and needs expensive stomach surgery. You forgot to get pet insurance and this surgery is going to cost almost 5,000. Do you let your dog suffer in agony or do you move back in with your parents so you can use the money you have saved to save your dog.";
            this.choice1Text = "Move back home";
            this.choice2Text = "Let the dog suffer";
            this.phaseCodes = new int[3] {3,4,5};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Your dog undergoes sucessful surgery.";
                this.effectText = "-5000 Money";
            }
            else if (c == 2)
            {
                this.resultText = "Your dog survives the surgery but has to take medications for the rest of its life adding to the costs.";
                this.effectText = "-6000 Money +2 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "Unfortinuely your dog does not survive the surgery.";
                this.effectText = "-5 Happiness";
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
                this.resultText = "Your dog passes away from the pain.";
                this.effectText = "-5 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "Despite having a padlock in its belly, your dog lives a happy life.";
                this.effectText = "+2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "Unfortinutely, the pain becomes too severe for the dog and you are forced to have the dog put down.";
                this.effectText = "-1500 Money -5 Happiness";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
