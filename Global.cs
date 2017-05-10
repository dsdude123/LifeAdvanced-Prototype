using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{
    class Global
    {
        public static int demoPos = 20;
        public static Player p1, p2, p3, p4, p5;
        public static int numPlayers;
        public static int playerTurn = 1;
        public static Event currentEvent;
        public static List<Event> eventDatabase;

        public static int[] cardTiles;


        public static void populateDatabase()
        {
            eventDatabase = new List<Event>();
            eventDatabase.Add(new Events.CarCrash());

        }


        public static Event getRandomEvent()
        {
            Random c = new Random();
            return eventDatabase.ElementAt(c.Next(0, (eventDatabase.Capacity - 1)));   
        }

    }
}
