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
            this.eventText = "Event text here";
            this.choice1Text = "Stay at Scene";
            this.choice2Text = "Flee";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
        }
        public override void choice1()
        {
            return;
        }
        public override void choice2()
        {
            return;
        }


        

    }
}
