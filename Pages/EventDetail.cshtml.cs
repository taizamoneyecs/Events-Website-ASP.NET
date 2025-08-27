using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace soft20181_starter.Pages
{
    public class Index1Model : PageModel
    {
        public List<EventModel> Events { get; set; } = new List<EventModel>();
        

        public void OnGet()
        {
            Events.AddRange(new List<EventModel>
            
            {
                new EventModel
                {
                    Id = 1,
                    Name = "Empower Her",
                    Description = "Leadership workshop for women",
                    Location = "Women's Center Auditorium",
                    EventDateTime = DateTime.Now.AddDays(5),
                    
                },
                new EventModel
                {
                    Id = 2,
                    Name = "Sisters United",
                    Description = "Cultural Celebration and networking",
                    Location = "Unity Hall",
                    EventDateTime = DateTime.Now.AddDays(10),
                    
                },
                new EventModel
                {
                    Id = 3,
                    Name = "Wellness & Self-care retreat",
                    Description = "Serenity Spa & Resort",
                    Location = "Battersea Spas",
                    EventDateTime = DateTime.Now.AddDays(15),
                    
                },
                new EventModel
                {
                    Id = 4,
                    Name = "EntreprenHER Summit ",
                    Description = "Learning business ideologies",
                    Location = "Posperity Conference Center",
                    EventDateTime = DateTime.Now.AddDays(20),
                    
                },
                new EventModel
                {
                    Id = 5,
                    Name = "Muslim Women Connect",
                    Description = "Interfaith Dialogy and Community-building",
                    Location = "Harmony Mosque",
                    EventDateTime = DateTime.Now.AddDays(25),
                    
                },
                new EventModel
                {
                    Id = 6,
                    Name = "Latina Power",
                    Description = "Advocacy and activism forum",
                    Location = "Diversity Community Center",
                    EventDateTime = DateTime.Now.AddDays(30),
                    
                }

            });
        }
    }

    public class EventModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime? EventDateTime { get; set; }
        public string? CoverPhoto { get; set; }
    }
}




