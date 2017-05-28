using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{
    class Player
    {

        public int tilePos;


        //String playerName;
        //Money funds;

        //GameStat stress;
        //GameStat energy;
        //GameStat PWB;
        //mising some stats here
        //int lifeTiles;

        public Player() 
        {
            tilePos = 0;
        }

        public Player(int startPos)
        {
            tilePos = startPos;
        }

        public int getPhase(){
            if (tilePos < 6)
            {
                return 1;
            }
            else if (tilePos < 11)
            {
                return 2;
            }
            else if (tilePos < 16)
            {
                return 3;
            }
            else if (tilePos < 21)
            {
                return 4;
            }
            else if (tilePos < 26)
            {
                return 5;
            }
            else if (tilePos < 31)
            {
                return 6;
            }
            else if (tilePos < 36)
            {
                return 7;
            }
            else if (tilePos < 41)
            {
                return 8;
            }
            else if (tilePos < 46)
            {
                return 9;
            }
            else if (tilePos == 46)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }

    }
}
