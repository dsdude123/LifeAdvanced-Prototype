using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class BadWeather : Event
    {
        public BadWeather()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Stormy Weather";
            this.eventText = "You have an outdoor event to attend today and the weather forecast calls for stormy weather.";
            this.choice1Text = "Ignore the forecast";
            this.choice2Text = "Stay at home indoors";
            this.phaseCodes = new int[9] {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "The majority of the storm ends up passing south of you.";
                this.effectText = "No effect";
            }
            else if (c == 2)
            {
                this.resultText = "Despite the weather, the event goes on as planned.";
                this.effectText = "+2 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "The storm ends up being much more severe than expected and you are injured by a falling tree branch.";
                this.effectText = "-5 Physical Wellbeing";
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
                this.resultText = "The event ends up being postponed because of the weather.";
                this.effectText = "-1 Stress";
            }
            else if (c == 2)
            {
                this.resultText = "The storm ends up not being as bad as expected.";
                this.effectText = "-1 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You decide to stay home.";
                this.effectText = "No effect";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
