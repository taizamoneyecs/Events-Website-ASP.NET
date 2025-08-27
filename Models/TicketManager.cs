using System.Collections.Generic;

namespace soft20181_starter.Models
{
    public static class TicketManager
    {
        public static List<int> TicketList { get; } = new List<int>();

        public static void AddTicket(int eventId)
        {
            TicketList.Add(eventId);
        }

        public static void ClearTickets()
        {
            TicketList.Clear();
        }
    }
}