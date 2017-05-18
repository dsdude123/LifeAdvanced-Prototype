using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{
    class Global
    {
        public static int demoPos = 6;
        public static int endPos = 26;
        public static Player p1, p2, p3, p4, p5;
        public static int numPlayers;
        public static int playerTurn = 1;
        public static Event currentEvent;
        public static CardEvent currentCardEvent;
        public static List<Event> eventDatabase;
        public static List<CardEvent> cardDatabase;
        public static bool isCard = false;

        public static int[] cardTiles = new int[9] {2,8,15,18,22,26,32,36,41};


        public static void populateDatabase()
        {
            eventDatabase = new List<Event>();
            eventDatabase.Add(new Events.CarCrash());
            eventDatabase.Add(new Events.Fired());
            eventDatabase.Add(new Events.GamblingAddiction());
            eventDatabase.Add(new Events.IdentityTheft());
            eventDatabase.Add(new Events.JobOffer());
            eventDatabase.Add(new Events.LateForWork());
            eventDatabase.Add(new Events.Match4());
            eventDatabase.Add(new Events.PhysicalTrainingDay());
            //eventDatabase.Add(new Events.Pregnant()); No longer used
            eventDatabase.Add(new Events.SoccerWindow());
            eventDatabase.Add(new Events.StudyAbroad());
            eventDatabase.Add(new Events.UnitedAirlines());
            eventDatabase.Add(new Events.WonJobVacation());
        }

        public static void populateCardDatabase()
        {
            cardDatabase = new List<CardEvent>();
            cardDatabase.Add(new CardEvents.TestCard());
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

        public static int getCurrentPhase()
        {
            if (Global.playerTurn == 1)
            {
                return p1.getPhase();
            }
            else if (Global.playerTurn == 2)
            {
                return p2.getPhase();
            }
            else if (Global.playerTurn == 3)
            {
                return p3.getPhase();
            }
            else if (Global.playerTurn == 4)
            {
                return p4.getPhase();
            }
            else if (Global.playerTurn == 5)
            {
                return p5.getPhase();
            }

            throw new ExecutionEngineException();
        }
    }
}
