using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class UnitedAirlines : Event
    {
        public UnitedAirlines()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Overbooking";
            this.eventText = "After boarding your flight, it is announced that it is overbooked and that a volunteer needs to leave the plane. No one volunteers and the automated system selects you to be removed.";
            this.choice1Text = "Leave";
            this.choice2Text = "Stay on board";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "The airline refunds your ticket.";
                this.effectText = "+400 Money";
            }
            else if (c == 2)
            {
                this.resultText = "You feel that you were treated unfairly for the removal.";
                this.effectText = "-3 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You exit the aircraft without complaint.";
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
                this.resultText = "Your attempt to stay results in a physical altercation.";
                this.effectText = "-3 Physical Wellbeing";
            }
            else if (c == 2)
            {
                this.resultText = "You are arrested by airport police.";
                this.effectText = "+2 Stress";
            }
            else if (c == 3)
            {
                this.resultText = "You file a lawsuit for the improper removal and win the lawsuit.";
                this.effectText = "+700 Money";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
