using CST8359_Lab3.Models;

namespace CST8359_Lab3.Data
{
    public class DbInitializer
    {
        // Seeds the database with some default values.
        public static void Seed(ApplicationDbContext context)
        {
            // Return if the database need not be seeded
            if (context.RsvpDbSet.Any())
            {
                return;
            }

            // create a few Rsvps
            var rsvps = new Rsvp[]
            {
                new Rsvp
                {
                    FullName = "Kyle Maclachlan",
                    NeedsAccommodation = true,
                    WorkshopTitle = "Woodworking"
                },
                new Rsvp
                {
                    FullName = "Jack Nance",
                    NeedsAccommodation = false,
                    WorkshopTitle = "Pottery"
                },
                new Rsvp
                {
                    FullName = "Sheryl Lee",
                    NeedsAccommodation = false,
                    WorkshopTitle = "Welding"
                }
            };

            // add, save
            context.RsvpDbSet.AddRange( rsvps );
            context.SaveChanges();
        }
    }
}
