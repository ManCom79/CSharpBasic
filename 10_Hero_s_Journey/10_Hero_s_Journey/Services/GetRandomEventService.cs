namespace Services
{
    public static class GetRandomEventService
    {
        public static int GetEvent(List<int> availableEvents)
        {
            Random rnd = new Random();
            int eventId = rnd.Next(0, availableEvents.Count - 1);
            int selectedEventId = availableEvents[eventId];

            availableEvents.Remove(availableEvents[eventId]);
            return selectedEventId;
        }
    }
}
