using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{
    class Global
    {
        public static int demoPos = 6;
        public static int endPos = 8;
        public static Player p1, p2, p3, p4, p5;
        public static int numPlayers;
        public static int playerTurn = 1;
        public static Event currentEvent;
        public static CardEvent currentCardEvent;
        public static List<Event> eventDatabase;
        public static List<CardEvent> cardDatabase;

        public static int[] cardTiles = new int[9] {2,8,15,18,22,26,32,36,41};


        public static void populateDatabase()
        {
            eventDatabase = new List<Event>();
            eventDatabase.Add(new Events.CarCrash());
        }

        public static void populateCardDatabase()
        {
            cardDatabase = new List<CardEvent>();
            //Add card events here
        }


        public static Event getRandomEvent()
        {
            if (((eventDatabase.Count() - 1) == 0))
            {
                return eventDatabase.ElementAt(0);
            }
            else
            {
                Random c = new Random();
                return eventDatabase.ElementAt(c.Next(0, (eventDatabase.Count() - 1)));  
            }
 
        }
    }
}
