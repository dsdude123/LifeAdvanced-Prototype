using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeAdvanced.Events
{
    class StudyFriend : Event
    {
        public StudyFriend()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "To Study, or Not to Study ";
            this.eventText = "You have a big test coming up tomorrow. You were just about to study for the test when a friend calls wanting to hang out.";
            this.choice1Text = "Study";
            this.choice2Text = "Hang out";
            this.phaseCodes = new int[2] { 2, 3};
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "You ace the test the next day.";
                this.effectText = "+10 Knowledge";
            }
            else if (c == 2)
            {
                this.resultText = "Despite your efforts, you don't do well on the test.";
                this.effectText = "-2 Knowledge";
            }
            else if (c == 3)
            {
                this.resultText = "You end up finishing studying early and still have time to hang out with friends.";
                this.effectText = "+2 Knowledge +2 Happiness";
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
                this.resultText = "You fail the test the next day.";
                this.effectText = "-5 Knowledge";
            }
            else if (c == 2)
            {
                this.resultText = "You have a great time with friends and do well on the test despite the lack of studying.";
                this.effectText = "+3 Happiness";
            }
            else if (c == 3)
            {
                this.resultText = "You end up cramming for the test late that night.";
                this.effectText = "+1 Stress +2 Knowledge";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
