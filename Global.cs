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
        public static List<Event> eventDatabase;

        public static int[] cardTiles = new int[9] {2,8,15,18,22,26,32,36,41};


        public static void populateDatabase()
        {
            eventDatabase = new List<Event>();
            eventDatabase.Add(new Events.CarCrash());
            eventDatabase.Add(new Events.CarCrash());//Temporary to populate database
            eventDatabase.Add(new Events.CarCrash());

        }


        public static Event getRandomEvent()
        {
            //TODO: Fix 1 event or empty database bug
            Random c = new Random();
            return eventDatabase.ElementAt(c.Next(0, (eventDatabase.Capacity - 1)));   
        }

    }
}
