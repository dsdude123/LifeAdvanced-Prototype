using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{
    public abstract class CardEvent:Event
    {
        public String eventName;
        public String eventText;

        public String resultText;
        public String effectText;

        public Random effectChooser;

        public int[] phaseCodes;

        public String cardCode;

        public override void choice1()
        {
            return; //Depreciated
        }
        public override void choice2()
        {
            return; //Depreciated
        }
    }
}
