using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsManagementSystem.Models;

namespace SportsManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class SportsDbContext : DbContext
    {
        public SportsDbContext(DbContextOptions<SportsDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<CompetitorGame> CompetitorGames { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventOutcome> EventOutcomes { get; set; }
        public DbSet<EventPhoto> EventPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CompetitorGame>()
                .HasKey(c => new { c.CompetitorId, c.GameId });
            builder.Entity<EventOutcome>()
                .HasKey(c => new { c.EventId, c.CompetitorId });

            string[] names =
            {
                "Jani Hosea",
                "Petrina Bassi",
                "Antione Yearta",
                "Ashton Tackett",
                "Latisha Skerrett",
                "Bernice Moorman",
                "Chasity Wesolowski",
                "Mike Pautz",
                "Isela Spiegel",
                "Shizue Theiss",
                "Brandon Musgrove",
                "Palmira Halbert",
                "Lewis Hohl",
                "Dottie Hitchens",
                "Kristine Guidry",
                "Carita Schlegel",
                "Mattie Tally",
                "Craig Kimpel",
                "Susy Mullett",
                "Arvilla Tedrow",
                "Julie Wimbish",
                "Sasha Shufelt",
                "Janett Wenger",
                "Carroll Pogue",
                "Helen Kerry",
                "Marta Belle",
                "Kristel Ringer",
                "Georgetta Pelham",
                "Rosalinda Gorrell",
                "Tomasa Vendetti"
            };
            string[] salutes = { "Mr", "Mrs", "Miss", "Mr", "Mrs", "Mrs", "Mrs", "Mrs", "Mr", "Mrs", "Mr", "Mrs", "Mr", "Mrs", "Mr", "Miss", "Mrs", "Miss", "Mr", "Mrs", "Mrs", "Mr", "Mrs", "Mrs", "Miss", "Mrs", "Miss", "Mrs", "Miss", "Miss" };
            string[] DOBs =
            {
                "07/05/1980",
                "31/05/1980",
                "14/07/1980",
                "02/12/1980",
                "04/01/1982",
                "17/03/1982",
                "17/06/1983",
                "07/02/1984",
                "15/04/1984",
                "19/11/1984",
                "16/08/1985",
                "28/10/1986",
                "25/12/1988",
                "05/01/1989",
                "12/01/1989",
                "15/02/1989",
                "13/05/1990",
                "09/07/1990",
                "06/02/1992",
                "15/06/1993",
                "11/02/1994",
                "21/07/1994",
                "23/12/1994",
                "25/02/1996",
                "17/07/1997",
                "02/12/1982",
                "22/01/1983",
                "09/02/1983",
                "05/04/1996",
                "07/10/1997"
            };
            string[] Emails =
            {
                "skajan@att.net",
                "lukka@msn.com",
                "majordick@live.com",
                "galbra@optonline.net",
                "bflong@comcast.net",
                "juliano@yahoo.com",
                "hmbrand@att.net",
                "ninenine@msn.com",
                "oracle@verizon.net",
                "hermanab@msn.com",
                "tromey@gmail.com",
                "bogjobber@yahoo.com",
                "irving@optonline.net",
                "cliffordj@mac.com",
                "dkasak@outlook.com",
                "petersen@mac.com",
                "wojciech@optonline.net",
                "odlyzko@comcast.net",
                "retoh@gmail.com",
                "mgemmons@att.net",
                "tezbo@live.com",
                "wildfire@yahoo.com",
                "juliano@icloud.com",
                "drewf@yahoo.ca",
                "crandall@sbcglobal.net",
                "staffelb@comcast.net",
                "mcnihil@aol.com",
                "airship@gmail.com",
                "shaffei@icloud.com",
                "oechslin@gmail.com"
            };
            string[] Countries =
            {
                "Cambodia", "Guinea", "Ukraine", "Sri Lanka", "Western Sahara", "Iceland", "Northern Mariana Islands",
                "Indonesia", "Azerbaijan", "Solomon Islands", "Sweden", "Australia", "South Korea", "Christmas Island",
                "Wallis and Futuna", "Kiribati", "Equatorial Guinea", "Liechtenstein", "France", "Greenland",
                "Bouvet Island", "Saint Martin", "Norway", "Russia", "French Southern Territories", "Olympics", "Olympics", "Olympics", "Olympics", "Olympics"
            };
            string[] Genders =
            {
                "Male", "Female", "Male", "Female", "Female", "Male", "Male", "Female", "Male", "Male", "Female", "Female", "Female", "Male", "Male", "Female", "Male", "Male", "Female", "Male", "Male", "Female", "Male",
                "Male", "Female", "Female", "Male", "Female", "Male", "Male"
            };

            for (int i = 0; i < names.Length; i++)
            {
                Trace.WriteLine(i);
                builder.Entity<Competitor>()
                    .HasData(
                        new Competitor
                        {
                            CompetitorId = i+1,
                            Name = names[i],
                            Country = Countries[i],
                            Dob = DateTime.Parse(DOBs[i]),
                            Salutation = salutes[i],
                            Email = Emails[i],
                            Gender = Genders[i]
                        });
            }
        }
    }
}
