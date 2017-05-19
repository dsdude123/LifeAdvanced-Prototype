using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.CardEvents
{
    class RadioContest : CardEvent
    {
        public RadioContest()
        {
            this.cardCode = "GIVEAWAY";
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Radio Contest Winner";
            int phase = Global.getCurrentPhase();
            if (phase == 1)
            {
                this.resultText = "Phase 1";
                this.effectText = "1";
            }
            else if (phase == 2)
            {
                this.resultText = "Money's too tight at the moment and you can’t afford the trip, even with the free tickets.";
                this.effectText = "-6 Happiness";
            }
            else if (phase == 3)
            {
                this.resultText = "You get to meet your favorite artist and watch the show from backstage!";
                this.effectText = "+7 Happiness";
            }
            else if (phase == 4)
            {
                this.resultText = "Your crazy schedule causes you to be late to the airport and miss your flight, you must spend tons of extra money to catch the next one so you don’t miss the show.";
                this.effectText = "-800 Money";
            }
            else if (phase == 5)
            {
                this.resultText = "The show gets cancelled but the artist decides to put on a private show for the contest winners and VIP ticket holders.";
                this.effectText = "-5 Stress";
            }
            else if (phase == 6)
            {
                this.resultText = "Phase 6";
                this.effectText = "6";
            }
            else if (phase == 7)
            {
                this.resultText = "Phase 7";
                this.effectText = "7";
            }
            else if (phase == 8)
            {
                this.resultText = "Phase 8";
                this.effectText = "8";
            }
            else if (phase == 9)
            {
                this.resultText = "Phase 9";
                this.effectText = "9";
            }
        }
    }
}
