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
            eventDatabase.Add(new Events.BusFare());
            eventDatabase.Add(new Events.CompanyRumor());
            eventDatabase.Add(new Events.Divorce());
            eventDatabase.Add(new Events.DogPadlock());
            eventDatabase.Add(new Events.Earthquake());
            eventDatabase.Add(new Events.FriendTheft());
            eventDatabase.Add(new Events.GFCheat());
            eventDatabase.Add(new Events.Hacker());
            eventDatabase.Add(new Events.Layoff());
            eventDatabase.Add(new Events.MMAWeed());
            eventDatabase.Add(new Events.NightOut());
            eventDatabase.Add(new Events.SnowBirthday());
            eventDatabase.Add(new Events.UnusualPain());
            eventDatabase.Add(new Events.ValuesConflict());
            
        }

        public static void populateCardDatabase()
        {
            cardDatabase = new List<CardEvent>();
            cardDatabase.Add(new CardEvents.TestCard());
            cardDatabase.Add(new CardEvents.BreakIn());
            cardDatabase.Add(new CardEvents.CarCrash2());
            cardDatabase.Add(new CardEvents.Earthquake2());
            cardDatabase.Add(new CardEvents.Hacker2());
            cardDatabase.Add(new CardEvents.HouseFire());
            cardDatabase.Add(new CardEvents.JobPromotion());
            cardDatabase.Add(new CardEvents.LargeInheritance());
            cardDatabase.Add(new CardEvents.Paris());
            cardDatabase.Add(new CardEvents.RadioContest());
            cardDatabase.Add(new CardEvents.SemiTruckCrash());
            cardDatabase.Add(new CardEvents.Snowstorm());
            cardDatabase.Add(new CardEvents.Windstorm());
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

        public static int getCurrentTile()
        {
            if (Global.playerTurn == 1)
            {
                return p1.tilePos;
            }
            else if (Global.playerTurn == 2)
            {
                return p2.tilePos;
            }
            else if (Global.playerTurn == 3)
            {
                return p3.tilePos;
            }
            else if (Global.playerTurn == 4)
            {
                return p4.tilePos;
            }
            else if (Global.playerTurn == 5)
            {
                return p5.tilePos;
            }

            throw new ExecutionEngineException();
        }
    }
}
