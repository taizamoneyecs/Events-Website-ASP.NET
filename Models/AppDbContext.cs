using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;
using soft20181_starter.Pages;

namespace soft20181_starter.Models
{


    //
    public class AppDbContext : DbContext
    {
        public DbSet<ticketpageModel> Tickets { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    };
}


       