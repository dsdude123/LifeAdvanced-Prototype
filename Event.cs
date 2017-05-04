using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{   
    public interface Event
    {
        String eventName{get; set;}
        String eventText{ get; set; }

        String choice1Text{ get; set; }
        String choice2Text{ get; set; }

        String resultText{ get; set; }

        void choice1();
        void choice2();

        void choice1Result();
        void choice2Result();
    }
}
