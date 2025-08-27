using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
namespace soft20181_starter.Pages
{
    public class ticketpageModel : PageModel
    {
        public List<int> TicketList => TicketManager.TicketList;
        public List<int> EventIds { get; set; }

        public ticketpageModel()
        {
            EventIds = new List<int> { 1, 2, 3, 4, 5}; 
        }

        public IActionResult OnPost(int eventId)
        {
            if (eventId != 0)
            {
                TicketManager.AddTicket(eventId);
            }

            return RedirectToPage();
        }
    }

}



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


