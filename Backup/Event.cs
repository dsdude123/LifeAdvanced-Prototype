using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{   
    public abstract class Event
    {
        public String eventName;
        public String eventText;

        public String choice1Text;
        public String choice2Text;

        public String resultText;
        public String effectText;

        public Random effectChooser;

        public int[] phaseCodes;

        public abstract void initEvent();

        public abstract void choice1();
        public abstract void choice2();
        

    }
}
