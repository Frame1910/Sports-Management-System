using System;
using System.Collections.Generic;
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

        public DbSet<Game> Games { get; set; }
        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<CompetitorGame> CompetitorGames { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventOutcome> EventOutcomes { get; set; }
        public DbSet<EventPhoto> EventPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CompetitorGame>()
                .HasKey(c => new {c.CompetitorId, c.GameId});
            builder.Entity<EventOutcome>()
                .HasKey(c => new {c.EventId, c.CompetitorId});
        }
    }
}
