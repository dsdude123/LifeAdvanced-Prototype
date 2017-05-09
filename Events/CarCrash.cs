﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class CarCrash : Event
    {

        public override void initEvent()
        {
            this.eventName = "Car Accident";
            this.eventText = "Event text here";
            this.choice1Text = "Stay at Scene";
            this.choice2Text = "Flee";
        }
        public override String[] choice1()
        {
            return new String[3];
        }
        public override String[] choice2()
        {
            return new String[3];
        }


        

    }
}