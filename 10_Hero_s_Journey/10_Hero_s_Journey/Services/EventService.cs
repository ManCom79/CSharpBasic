namespace Services
{
    public class EventService
    {
        public static KeyValuePair<string, int> Event(int selectedEventId) {

            Dictionary<string, int> events = new Dictionary<string, int>() { 
                {"Bandits attack you out of nowhere. They seem very dangerous...", -20 }, 
                {"You bump in to one of the guards of the nearby village. They attack you without warning...", -30}, 
                {"A Land Shark appears. It starts chasing you down to eat you...", -50 }, 
                {"You accidentally step on a rat. His friends are not happy. They attack..", -10 }, 
                {"You find a huge rock. It comes alive somehow and tries to smash you...", -30 } 
            };

            KeyValuePair<string, int> currentEvent = events.ElementAt(selectedEventId);

            return currentEvent;
        }
    }
}
