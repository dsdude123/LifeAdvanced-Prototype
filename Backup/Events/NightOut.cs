using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class NightOut : Event
    {
        public NightOut()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Night Out";
            this.eventText = "You’ve just had a baby! Your partner has plans for a night out with friends and you have agreed to stay home and watch the baby, BUT, your friend scores front row tickets to a Seahawks game.";
            this.choice1Text = "Go to the game and have your partner cancel plans";
            this.choice2Text = "Decline the offer";
            this.phaseCodes = new int[1] { 3};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Your partner understands, tells you to have a nice time.";
                this.effectText = "+5 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "Your partner says this is okay, but is fuming and let’s you know how mad they are when you get home from your awesome game.";
                this.effectText = "+3 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "Your partner says okay, you go and end up getting into a fist fight at the game and break your nose.";
                this.effectText = "-300 Money -1 Physical Wellbeing";
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
                this.resultText = "Your partner insists that you go, these tickets really are once in a lifetime!";
                this.effectText = "+2 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "Your partner is thankful for your decision, you watch the game on tv and it turns out that you would have met the entire team had you went to the game.";
                this.effectText = "-5 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You stay home and the baby breaks out in a rash, you rush to the ER.";
                this.effectText = "-200 Money";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
    }
}
