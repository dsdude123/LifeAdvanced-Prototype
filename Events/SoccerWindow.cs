using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced.Events
{
    class SoccerWindow : Event
    {
        int player;

        public SoccerWindow()
        {
            initEvent();
        }

        public override void initEvent()
        {
            this.eventName = "Window Smasher"; //Maybe get a better title
            Random B = new Random();
            player = Global.playerTurn;
            while (player != Global.playerTurn){
            player = B.Next(1,Global.numPlayers+1);
            }
            this.eventText = "While playing soccer, you break the window of Player " + player +"'s home.";
            this.choice1Text = "Run away";
            this.choice2Text = "Tell the player";
            this.phaseCodes = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
            this.effectChooser = new Random();
        }
        public override void choice1()
        {
            int c = effectChooser.Next(1, 4);
            if (c == 1)
            {
                this.resultText = "Player " + player + " catches you trying to flee.";
                this.effectText = "-200 Money to Player " + Global.playerTurn + " +200 Money to Player " + player ;
            }
            else if (c == 2)
            {
                this.resultText = "You sucessfuly escape.";
                this.effectText = "No effect";
            }
            else if (c == 3)
            {
                this.resultText = "The other player begins to chase you and in the chase you trip and are injured from the fall.";
                this.effectText = "-2 Physical wellbeing";
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
                this.resultText = "Your apology to the other player is accepted.";
                this.effectText = "+3 Happiness";
            }
            else if (c == 2)
            {
                this.resultText = "The other player asks you to pay for repairs.";
                this.effectText = "-100 Money to Player " + Global.playerTurn + " +100 Money to Player " + player;
            }
            else if (c == 3)
            {
                this.resultText = "You are blamed by the player."; //What?
                this.effectText = "+1 Stress";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

    }
}
