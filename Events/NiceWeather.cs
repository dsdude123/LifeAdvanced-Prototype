using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class NiceWeather : Event

    {
    public NiceWeather()
    {
        initEvent();
    }

    public override void initEvent()
    {
        this.eventName = "Good Forecast";
        this.eventText =
            "The weather is expected to be nice today. A new beach opened up recently in your area. How do you want to spend the day?";
        this.choice1Text = "Go to the beach";
        this.choice2Text = "Stay indoors";
        this.phaseCodes = new int[9] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        this.effectChooser = new Random();
    }

    public override void choice1()
    {
        int c = effectChooser.Next(1, 4);
        if (c == 1)
        {
            this.resultText = "You have a relaxing day at the beach.";
            this.effectText = "-2 Stress";
        }
        else if (c == 2)
        {
            this.resultText =
                "You end up getting sunburned.";
            this.effectText = "-1 Physical Wellbeing";
        }
        else if (c == 3)
        {
            this.resultText =
                "You end up running into some friends at the beach and have a great day.";
            this.effectText = "+3 Happiness";
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
            this.resultText =
                "The weather ends up being the opposite of the forecast and stormy.";
            this.effectText = "No effect";
        }
        else if (c == 2)
        {
            this.resultText =
                "You relax at home.";
            this.effectText = "-2 Stress";
        }
        else if (c == 3)
        {
            this.resultText = "You end up being bored with nothing to do.";
            this.effectText = "-3 Happiness";
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

    }
    }
}
