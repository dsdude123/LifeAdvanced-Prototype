using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class FriendTheft : Event
    {
        public FriendTheft()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Break-In";
            this.eventText = "Your apartment got broken into while you were at school. Your computer, nice watch, cash, and other valuables were stolen. Your best friend all the sudden has the money to do expensive performance modifications to his car now. You're almost sure that your friend robbed you but you can't be quite positive. Do you break up your friendship with him or continue to be friends with him.";
            this.choice1Text = "Break up friendship";
            this.choice2Text = "Stay friends";
            this.phaseCodes = new int[1] {3};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You terminate the friendship.";
                this.effectText = "-1 Happiness -700 Money";
            }
            else if (c == 2)
            {
                this.resultText = "After confronting your friend about the issue, he admits to the theft and gives you the money he made off your stuff. You end the friendship.";
                this.effectText = "-2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You break up the friendship but find out later that he didn't steal the stuff when the police recover you stolen items in an unrelated crime ring bust.";
                this.effectText = "-5 Happiness -5 Stress";
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
                this.resultText = "You decide to remain friends and later find that your friend was innocent when the police recover your stolen items from another person.";
                this.effectText = "+5 Happiness -5 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "You decide to remain friends but later find more of your items stolen.";
                this.effectText = "-900 Money";
            }
            else if (c == 3)
            {
                this.resultText = "You decide to stay friends despite the theft.";
                this.effectText = "-700 Money";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
